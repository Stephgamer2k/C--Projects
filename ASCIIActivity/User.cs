using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIIActivity
{
    class User
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }



        public User (string name, string AccountNumber)
        {
            this.Name = name;
            this.AccountNumber = AccountNumber;
        }



    }
}
