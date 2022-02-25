using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recepti_12b_ASP.Models
{
    public class Recipe
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string DishName { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public string RequiredProducts { get; set; }

        [Required]
        public string CookDescription { get; set; }
    }
}
