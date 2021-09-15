using System;
using System.ComponentModel.DataAnnotations;

namespace TZ.Model
{
    public class Order
    {
        [Required]
        [MaxLength(50,ErrorMessage = "Too much symbols")]
        public string SenderCity { get; set; }
        
        [Required]
        [MaxLength(50,ErrorMessage = "Too much symbols")]
        public string SenderAddress { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Too much symbols")]
        public string RecipientCity { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage = "Too much symbols")]
        public string RecipientAddress { get; set; }

      
        public int Weight { get; set; }

        public DateTimeOffset Data { get; set; }
        
        [Key]
        public Guid Id { get; set; }
    }
}