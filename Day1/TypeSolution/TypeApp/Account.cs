using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeApp
{
    public partial class Account
    {
        public Account() { }
        public int AccountId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public double Balance {  get; set; }
    }
}
