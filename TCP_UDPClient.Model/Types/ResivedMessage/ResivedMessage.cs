using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDPClient.ViewModel.Types
{
    public class ResivedMessage
    {
        public ResivedMessageInfo Info { get; init; }
        public ResivedMessageContent Content { get; init; }

        public ResivedMessage(ResivedMessageInfo info, ResivedMessageContent content)
        {
            Info = info;
            Content = content;
        }
    }
}
