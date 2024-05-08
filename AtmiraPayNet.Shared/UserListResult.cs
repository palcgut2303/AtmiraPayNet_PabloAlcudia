
using AtmiraPayNet.Shared.AccountDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmiraPayNet.Shared
{
    public class UserListResult
    {
        public List<UserDTO> ListUser { get; set; }
        public bool Successful { get; set; }
        public string Error { get; set; }

    }
}
