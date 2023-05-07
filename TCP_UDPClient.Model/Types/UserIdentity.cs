using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDPClient.ViewModel.Types
{
    public class UserIdentity
    {
        public IPAddress Address;

        public UserIdentity(IPAddress address)
        {
            Address = address;
        }

        public override string ToString()
        {
            return Address.ToString();
        }
    }
}
