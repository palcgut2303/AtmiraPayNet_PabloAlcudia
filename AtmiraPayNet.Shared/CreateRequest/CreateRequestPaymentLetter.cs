using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.CreateRequest
{
    public class CreateRequestPaymentLetter
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string OriginAccountIBAN { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string OriginBankName { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string OriginCountryBank { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string OriginCurrencyBank { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string CP { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Street { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int NumberStreet { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int PayAmount { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? DestinationAccountIBAN { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? DestinationBankName { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? DestinationCountryBank { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? DestinationCurrencyBank { get; set; }

        public string? InterBankAccountIBAN { get; set; }

        public string? InterBankName { get; set; }

        public string? PDF { get; set; }

        public string? Status { get; set; }


    }
}