using System;
using System.ComponentModel.DataAnnotations;

namespace src.Areas.crud.Models
{
    public class todoItem
    {
        public todoItem()
        {
            progress = 0;
        }
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string todo { get; set; }
        [Range(0, 100, ErrorMessage = "Enter a value between 1 and 100")]
        public int progress { get; set; }
    }
}
