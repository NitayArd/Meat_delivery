using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DtoLibary.Models.Atribute;

namespace DtoLibary
{
    public class User
    {
        [IsrealIdCheck(ErrorMessage = "Your ID is invalid.")]
        public string UserId { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d).{6,}$", ErrorMessage = "The password must be 6 characters or more, and must contain at least one letter and at least one number.")]

        public string UserPassword { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        [RegularExpression(@"^0(5\d|7\d|[23489])(-?\d{7})$", ErrorMessage = "The phone number is not proper .")]
        public string UserPhone { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string Addresses { get; set; }
    }
}
