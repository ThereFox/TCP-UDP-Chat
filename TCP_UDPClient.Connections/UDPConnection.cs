using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.Connections
{
    public class UDPConnection : IProtocolConnection
    {
        public event Action<ResivedMessage> GetNewMessage;

        public void Send(SendingMessage message)
        {
            throw new NotImplementedException();
        }
    }
}
