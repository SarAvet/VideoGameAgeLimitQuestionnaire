using Microsoft.EntityFrameworkCore;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Контекст данных
    /// </summary>
    public class QuestionnaireContext : DbContext
    {
        public QuestionnaireContext(DbContextOptions<QuestionnaireContext> options) : base(options) { }
        
        public DbSet<BinaryQuestion> BinaryQuestions { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
