using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared.AccountDTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public DateTime BirthDay { get; set; }
    }
}
