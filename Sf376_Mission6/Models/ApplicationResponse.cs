using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sf376_Mission6.Models
{
    public class ApplicationResponse
    {

        //declare variables, types, and specify required fields
        
        [Required(ErrorMessage ="Please select a rating from the list")]
        public string Rating { get; set; }
        
        [Required(ErrorMessage = "Please enter a title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the director's name")]
        public string Director { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        [Required(ErrorMessage = "Please select a category from the list")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required]
        [Key]
        public int id { get; set; }
    }
}
