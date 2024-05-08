using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.EntityDTO
{
    public class IBAN_DTO
    {
        public IBAN_DTO(string value)
        {
            IBANBankAccount = value;
        }

        public string IBANBankAccount { get; set; }
    }
}
