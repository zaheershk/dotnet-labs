using System;
using System.ComponentModel.DataAnnotations;

namespace OrderSvc.Models
{
    public class OrderModel
    {
        [Required] 
        public Guid CustomerGuid { get; set; }

        [Required] 
        public string CustomerFullName { get; set; }
    }
}