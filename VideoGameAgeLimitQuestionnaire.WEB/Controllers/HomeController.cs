using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VideoGameAgeLimitQuestionnaire.WEB.Models;
using VideoGameAgeLimitQuestionnaire.WEB.ViewModels;

namespace VideoGameAgeLimitQuestionnaire.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuestionnaireContext _context;

        public HomeController(QuestionnaireContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Questionnaire()
        {
            var questionList = _context.BinaryQuestions;

            var firstQuestion = questionList.FirstOrDefault(q => q.GetOrder() == 1);

            var viewModel = new QuestionnaireViewModel
            {
                Order = firstQuestion.Order,
                Text = firstQuestion.Text,
                Answers = firstQuestion.Answers
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Questionnaire(QuestionnaireViewModel viewModel)
        {
            ModelState.Remove("Order");

            var scrollBtnValue = Request.Form["scrollBtn"];

            int step;

            switch (scrollBtnValue)
            {
                case "prev":
                    step = -1;
                    break;

                case "next":
                    step = 1;
                    break;

                default:
                    step = 0;
                    break;
            }

            var questionList = _context.BinaryQuestions;

            var question =
                questionList.FirstOrDefault(q => q.GetOrder() == viewModel.Order + step);


            if (viewModel.SelectedAnswers != null && viewModel.SelectedAnswers.Any(a => a.Equals("True")))
            {
                var result = _context.BinaryQuestions.Include(q => q.Result).FirstOrDefault(q => q.Order == viewModel.Order)?.Result;

                return View("Result", result);
            }

            if (question == null)
            {
                var result = _context.Results.LastOrDefault();
                return View("Result", result);
            }

            viewModel.Order = question.Order;
            viewModel.Text = question.Text;
            viewModel.Answers = question.Answers;

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
