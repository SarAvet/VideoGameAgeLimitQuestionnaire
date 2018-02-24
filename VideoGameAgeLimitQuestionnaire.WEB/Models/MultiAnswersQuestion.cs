using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Вопрос с множественным выбором ответов
    /// </summary>
    public class MultiAnswersQuestion : IOrderable
    {
        public MultiAnswersQuestion()
        {
            Answers = new HashSet<Answer>();
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Текст вопроса
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Варианты ответов
        /// </summary>
        public virtual IEnumerable<Answer> Answers { get; set; }

        /// <summary>
        /// Результат
        /// </summary>
        public virtual Result Result { get; set; }

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int Order { get; set; }

        public int GetOrder()
        {
            return Order;
        }
    }
}
