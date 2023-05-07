using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TCP_UDPClient.ViewModel.Types
{
    public class MessageCollection
    {
        public IReadOnlyList<ResivedMessage> messages
        {
            get => _messages;
        }
        private List<ResivedMessage> _messages = new();

        public void AppendMessage(ResivedMessage message)
        {
            if (messages == null || message.Content == null)
            {
                throw new ArgumentNullException();
            }

            _messages.Add(message);

        }
        public void Clear()
        {
            _messages.Clear();
        }
    }
}
