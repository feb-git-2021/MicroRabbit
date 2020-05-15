using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        [Required]
        public int Id { get; set; }
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        public float TransferAmount { get; set; }
    }
}
