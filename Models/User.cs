using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zapper.Models
{
    public class User
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Settings { get; set; }
    }
}
