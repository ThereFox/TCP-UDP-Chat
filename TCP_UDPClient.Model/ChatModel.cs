using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.Model
{
    public class ChatModel
    {
        public event Action<ResivedMessage> NewMessageGetted;

        private IProtocolConnection _protocolConnection;

        public void Send(SendingMessage message)
        {
            _protocolConnection.Send(message);
        }

    }
}
