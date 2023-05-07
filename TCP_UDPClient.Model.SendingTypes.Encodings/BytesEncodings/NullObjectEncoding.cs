using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;

namespace TCP_UDPClient.Model.SendingTypes.Encodings.BytesEncodings
{
    public class NullObjectEncoding : IByteEncoding
    {
        public byte[] Encode(byte[] data)
        {
            return data;
        }

        public NullObjectEncoding()
        {
            
        }
    }
}
