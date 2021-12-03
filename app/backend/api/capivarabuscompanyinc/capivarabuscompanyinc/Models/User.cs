using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName {get; set; }

        public string UserLastName { get; set; }

        public string DateOfPurchase { get; set; }

        public string  IdFileName { get; set; }
    }
}
