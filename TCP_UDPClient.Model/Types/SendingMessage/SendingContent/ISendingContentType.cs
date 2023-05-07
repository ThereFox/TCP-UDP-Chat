using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDPClient.Model.Types.SendingMessage.SendingContent
{
    public interface ISendingContentType
    {
        public byte[] FormatData(string message, IByteEncoding encoding);
    }
}
