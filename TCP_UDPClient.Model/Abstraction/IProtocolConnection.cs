using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.Model
{
    public interface IProtocolConnection
    {
        public event Action<ResivedMessage> GetNewMessage;

        public void Send(SendingMessage message);
    }
}
