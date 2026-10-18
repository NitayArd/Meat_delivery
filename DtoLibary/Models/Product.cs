using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtoLibary.Models.Atribute;

namespace DtoLibary
{
    public class Product
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Field must be filled." )]
        [RegularExpression(@"^[A-Z] [a-z]+$", ErrorMessage = "The product name can only contain English letters.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Field must be filled.")]

        public string ProductDescription { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public double ProductPrice { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string ProductWeight { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public int ProductInventory { get; set; }
        [ImgCheck(ErrorMessage = "Your Image is invalid.")]
        public string ProductImage { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]

        public int CategoriesId { get; set; }



    }
}
