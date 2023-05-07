using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDPClient.ViewModel.Types
{
    public class ResivedMessageInfo
    {
        public DateTime ResipientsTime { get; init; }
        public UserIdentity Sender { get; init; }
        public UserIdentity Resipient { get; init; }

        public ResivedMessageInfo(UserIdentity sender, UserIdentity resipient)
        {
            Sender = sender;
            Resipient = resipient;
            ResipientsTime = DateTime.Now;
        }
    }
}
