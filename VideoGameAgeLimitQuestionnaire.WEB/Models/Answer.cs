using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Вариант ответа
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Текст варианта ответа
        /// </summary>
        [StringLength(250)]
        public string Text { get; set; }

        /// <summary>
        /// Признак, является ли ответ определяющим
        /// </summary>
        public bool IsDeterminateAnswer { get; set; }

        /// <summary>
        /// Вопрос
        /// </summary>
        public MultiAnswersQuestion MultiAnswersQuestion { get; set; }
    }
}
