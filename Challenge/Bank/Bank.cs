using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{   
    public class Bank
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Collection<IBankAccount> Accounts { get; set; }
    }
}
