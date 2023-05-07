using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.Model
{
    public class SendingMessage
    {
        public ISendingContentType ContentType;
        public IByteEncoding Encoding;
        public string Content;

        public SendingMessage(ISendingContentType contentType, IByteEncoding encoding, string content)
        {
            Content = content;
            ContentType = contentType;
            Encoding = encoding;
        }

        public byte[] FormatMessage()
        {
           return ContentType.FormatData(Content, Encoding);
        }

    }
}
