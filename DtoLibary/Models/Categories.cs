using DtoLibary.Models.Atribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLibary
{
    public class Categories
    {
        public int CategoriesId { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string CategoriesName { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        [ImgCheck(ErrorMessage = "Your Image is invalid.")]
        public string CategoriesImage { get; set; }
    }
}
