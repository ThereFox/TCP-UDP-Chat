using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;

namespace TCP_UDPClient.Model.SendingTypes.Base
{
    public class ASCIISendingContent : ISendingContentType
    {

        public byte[] FormatData(string message, IByteEncoding encoding)
        {
           return encoding.Encode(Encoding.ASCII.GetBytes(message));
        }

    }
}
