using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentalPlatform.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public int Quantity { get; set; }
        public DateTime PreferredDeliveryDate { get; set; }
        public virtual Product Product { get; set; }
    }
}
