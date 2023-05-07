using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;

namespace TCP_UDPClient.ViewModel.Types
{
    public class Avaliables
    {
        public string[] AvaliableConnections { get => Connections.Keys.ToArray(); }
        public string[] AvaliableContentsType { get => Contents.Keys.ToArray(); }
        public string[] AvaliableEncodingType { get => Encodings.Keys.ToArray(); }

        private Dictionary<string, IProtocolConnection> Connections { get; init; }
        private Dictionary<string, ISendingContentType> Contents { get; init; }
        private Dictionary<string, IByteEncoding> Encodings { get; init; }

        public Avaliables(
            Dictionary<string, IProtocolConnection> connections,
            Dictionary<string, ISendingContentType> contents,
            Dictionary<string, IByteEncoding> encodings
            )
        {
            Connections = connections;
            Contents = contents;
            Encodings = encodings;
        }

        public SendingMessage GetMessage(WritingMessage message)
        {
            return new SendingMessage(Contents[message.ContentType], Encodings[message.EncodingType], message.Message);
        }
    }
}
