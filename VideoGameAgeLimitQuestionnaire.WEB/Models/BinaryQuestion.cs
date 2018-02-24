using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoGameAgeLimitQuestionnaire.WEB.Models
{
    /// <summary>
    /// Вопрос ДА/НЕТ
    /// </summary>
    public class BinaryQuestion : IOrderable
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
        /// Определяющий ответ (1 - ДА, 0 - НЕТ)
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

        public int GetOrder()
        {
            return Order;
        }
    }
}
