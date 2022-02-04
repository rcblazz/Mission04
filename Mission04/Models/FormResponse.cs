using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }


        //Build foregin key Relationship
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        [Required(ErrorMessage ="You need to enter a valid Title!")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You need to enter a valid Year!")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "You need to enter a valid Director!")]
        public string Director { get; set; }
        [Required(ErrorMessage = "You need to enter a valid Rating!")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
        public int ApplicationId { get; internal set; }
    }
}
