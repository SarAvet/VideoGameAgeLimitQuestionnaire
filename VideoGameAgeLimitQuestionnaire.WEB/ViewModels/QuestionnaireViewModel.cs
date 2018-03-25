using System.Collections.Generic;
using VideoGameAgeLimitQuestionnaire.WEB.Models;

namespace VideoGameAgeLimitQuestionnaire.WEB.ViewModels
{
    public class QuestionnaireViewModel
    {
        public int Order { get; set; }
        public string Text { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public IEnumerable<string> SelectedAnswers { get; set; }
    }
}
