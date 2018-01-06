using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClasses.Models
{
    public class Transaction
    {
        public int id { get; set; }
        public double amount { get; set; }
        public string reference { get; set; }
        public DateTime date { get; set; }
        public string name { get; set; }
    }
}
