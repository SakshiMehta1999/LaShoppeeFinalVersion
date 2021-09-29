using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LaShoppeeFinalVersion.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
       
        [Required(ErrorMessage ="Please Enter Your First Name")]
        [Display(Name="First Name")]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        [Display(Name = "Street Address")]
        [StringLength(80)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Your City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Your State")]
        [StringLength(2,MinimumLength =2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter Your Zipcode")]
        [StringLength(5, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
       [BindNever]
        public decimal OrderTotal { get; set; }
        
        [BindNever]
        public DateTime OrderPlaced { get; set; }

    }
}
