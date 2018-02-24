using Microsoft.EntityFrameworkCore;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Контекст данных
    /// </summary>
    public class QuestionnaireContext : DbContext
    {
        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options) { }

        private DbSet<Answer> Answers { get; set; }
        private DbSet<BinaryQuestion> BinaryQuestions { get; set; }
        private DbSet<MultiAnswersQuestion> MultiAnswersQuestions { get; set; }
        private DbSet<Result> Results { get; set; }
    }
}
