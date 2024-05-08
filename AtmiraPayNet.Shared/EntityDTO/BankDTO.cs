using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.EntityDTO
{
    public class BankDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //List of the Bank AccountsDTO
        public List<BankAccountDTO>? BankAccountsDTO { get; set; }
    }
}
