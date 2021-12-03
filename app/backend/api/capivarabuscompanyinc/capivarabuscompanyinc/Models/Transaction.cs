using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public string UserId { get; set; }

        public string RouteName { get; set; }

        public string TransactionDate { get; set; }

              
    }
}
