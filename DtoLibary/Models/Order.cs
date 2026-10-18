using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLibary
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string OrderDate { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public bool OrderShipment { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public bool OrderStatusprovided { get; set; }
        [Required(ErrorMessage = "Field must be filled.")]
        public string UserId { get; set; }
        

    }
}
