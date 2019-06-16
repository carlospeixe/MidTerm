using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MidTerm.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        [StringLength(10,MinimumLength=4)]
        public string Name { get; set; }
    }
}