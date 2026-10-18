using DtoLibary.Models.Atribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLibary
{
    public class City
    {

        public int CityId { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        [RegularExpression(@"^[A-Z] [a-z]+$", ErrorMessage = "The product name can only contain English letters.")]
        [FirstLetterCapitalAttribute(ErrorMessage = "Your CityName is invalid.")]
        public string CityName { get; set; }
       
    }
}
