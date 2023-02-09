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
        
        [Required]
        public string Rating { get; set; }
        [Required]
        public string Category { get; set; }
        [Key]
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }
    }
}
