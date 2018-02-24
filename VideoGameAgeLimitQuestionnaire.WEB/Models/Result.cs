using System.ComponentModel.DataAnnotations;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Результат
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Текст результата
        /// </summary>
        [StringLength(500)]
        public string Text { get; set; }
    }
}
