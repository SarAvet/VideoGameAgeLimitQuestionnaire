using System.Collections.Generic;
using System.Linq;
using VideoGameAgeLimitQuestionnaire.WEB.Models;

namespace VideoGameAgeLimitQuestionnaire.WEB
{
    public static class QuestionnaireInitializer
    {
        public static void Seed(QuestionnaireContext context)
        {
            context.Database.EnsureCreated();

            if(context.Results.Any())
            {
                return;
            }

            var resultList = new List<Result>
            {
                new Result {Text = "Возрастное ограничение данной игры: +18"},
                new Result {Text = "Возрастное ограничение данной игры: +16"},
                new Result {Text = "Возрастное ограничение данной игры: +12"},
                new Result {Text = "Возрастное ограничение данной игры: +6"},
                new Result {Text = "Возрастное ограничение данной игры: +0"},
            };

            context.Results.AddRange(resultList);

            context.SaveChanges();

            context.BinaryQuestions.AddRange(new List<BinaryQuestion>
            {
                new BinaryQuestion
                {
                    Text = "Присутствует ли в сюжете игры натуралистические сцены половых отношений или сексуального насилия?",
                    DeterminateAnswer = true,
                    Result = resultList.FirstOrDefault(r => r.Id == 1),
                    Order = 1
                },
                new BinaryQuestion
                {
                    Text = "Встречаются ли в игре отдельные бранные слова и (или) выражения, относящиеся к нецензурной брани?",
                    DeterminateAnswer = true,
                    Result = resultList.FirstOrDefault(r => r.Id == 1),
                    Order = 2
                },
                new BinaryQuestion
                {
                    Text = "Игра содержит изображение или описание, побуждающие к совершению антиобщественных действий (в том числе к потреблению алкогольной и спиртосодержащей продукции, участию в азартных играх, занятию бродяжничеством или попрошайничеством)?",
                    DeterminateAnswer = true,
                    Result = resultList.FirstOrDefault(r => r.Id == 2),
                    Order = 3
                },
                new BinaryQuestion
                {
                    Text = "Содержит ли игра натуралистические изображение или описание несчастного случая, аварии, катастрофы либо ненасильственной смерти без демонстрации их последствий, которые могут вызывать у детей страх, ужас или панику?",
                    DeterminateAnswer = true,
                    Result = resultList.FirstOrDefault(r => r.Id == 3),
                    Order = 4
                },
                new BinaryQuestion
                {
                    Text = "Игра содержит информацию, причиняющую вреда здоровью и (или) развитию детей (в том числе информационная продукция, содержащая оправданные ее жанром и (или) сюжетом эпизодические ненатуралистические изображение или описание физического и (или) психического насилия (за исключением сексуального насилия) при условии торжества добра над злом и выражения сострадания к жертве насилия и (или) осуждения насилия)?",
                    DeterminateAnswer = true,
                    Result = resultList.FirstOrDefault(r => r.Id == 4),
                    Order = 5
                }
            });

            context.SaveChanges();
        }
    }
}
