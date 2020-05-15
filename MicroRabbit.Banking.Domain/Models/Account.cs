using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRabbit.Banking.Domain.Models
{
 public   class Account
    {
        [Required]
        public int Id { get; set; }
        public string AccountType { get; set; }
        public float AccountBalance { get; set; }
    }
}
