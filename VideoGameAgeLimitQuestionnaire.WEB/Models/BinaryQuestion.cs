using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using VideoGameAgeLimitQuestionnaire.WEB.ViewModels;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Вопрос ДА/НЕТ
    /// </summary>
    public class BinaryQuestion 
    {
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
        /// Определяющий ответ (true - ДА, false - НЕТ)
        /// </summary>
        public bool DeterminateAnswer { get; set; }

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Результат
        /// </summary>
        public virtual Result Result { get; set; }

        public int GetOrder() => Order;

        [NotMapped]
        public IEnumerable<Answer> Answers => new List<Answer>
        {
            new Answer { Text = "Да", IsDeterminateAnswer = DeterminateAnswer },
            new Answer { Text = "Нет", IsDeterminateAnswer = !DeterminateAnswer }
        };

    }
}
