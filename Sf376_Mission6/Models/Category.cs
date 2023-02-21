using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sf376_Mission6.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CatergoryId { get; set; }
        public string CatergoryName { get; set; }
    }
}
