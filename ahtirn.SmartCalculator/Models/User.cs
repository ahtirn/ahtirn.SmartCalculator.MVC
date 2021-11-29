using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ahtirn.SmartCalculator.Models
{
    public class User
    {
        /// <summary>
        /// <param name="Age">Возраст</param>
        /// </summary>
        public byte? Age { get; set; } 
        
        /// <summary>
        /// <param name="Weight">Вес</param>
        /// </summary>
        public ushort Weight { get; set; }

        /// <summary>
        ///<param name="Height">Рост</param>
        /// </summary>
        public ushort? Height { get; set; }

        /// <summary>
        /// <param name="Gender">Пол</param>
        /// </summary>
        [Required]
        public Gender? Gender { get; set; }
    }
    
    public enum Gender
    {
        [Description("Мужской")] Male = 1,
        [Description("Женский")] Female = 2
    }
}