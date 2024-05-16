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
        [Required(ErrorMessage = "La cuenta origen en formato IBAN es requerida")]
        public string OriginAccountIBAN { get; set; }
        [Required(ErrorMessage = "El nombre del banco origen es obligatorio")]

        public string OriginBankName { get; set; }
        [Required(ErrorMessage = "El país del banco origen es obligatorio")]
        public string OriginCountryBank { get; set; }
        [Required(ErrorMessage = "La divisa del país es obligatoria")]
        public string OriginCurrencyBank { get; set; }
        [Required(ErrorMessage = "El CP es obligatorio")]
        public string CP { get; set; }
        [Required(ErrorMessage = "La calle de la oficina es obligatoria")]
        public string Street { get; set; }

        [Required(ErrorMessage = "El numero de calle es obligatorio")]
        public int NumberStreet { get; set; }
        [Required(ErrorMessage = "La cantidad es obligatoria")]
        public int PayAmount { get; set; }
        [Required(ErrorMessage = "La cuenta destino en formato IBAN es requerida")]
        public string? DestinationAccountIBAN { get; set; }
        [Required(ErrorMessage = "El nombre del banco destino es obligatorio")]
        public string? DestinationBankName { get; set; }
        [Required(ErrorMessage = "El pais del banco destino es obligatorio")]
        public string? DestinationCountryBank { get; set; }
        [Required(ErrorMessage = "La divisa del pais destino es obligatoria")]
        public string? DestinationCurrencyBank { get; set; }

        public string? InterBankAccountIBAN { get; set; }

        public string? InterBankName { get; set; }

        public string? PDF { get; set; }

        public string? Status { get; set; }


    }
}