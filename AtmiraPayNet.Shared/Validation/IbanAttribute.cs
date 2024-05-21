using IbanNet;
using IbanNet.Validation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace AtmiraPayNet.Shared.Validation
{
    public class IbanAttribute : ValidationAttribute
    {
        private readonly IIbanValidator _ibanValidator;

        public IbanAttribute()
        {
            _ibanValidator = new IbanValidator();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var iban = value as string;

            if (iban == null)
            {
                return new ValidationResult("El IBAN es requerido");
            }

            iban = iban.Replace(" ", "");

            var validationResult = _ibanValidator.Validate(iban);

            if (validationResult.IsValid)
            {
                return ValidationResult.Success;
            }


            return new ValidationResult("Error");
        }
    }
}
