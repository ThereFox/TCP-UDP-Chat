using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP_UDPClient.ViewModel.Types
{
    public class ResivedMessageContent
    {
        public byte[] ByteContent { get; init; }
        public ResivedMessageContentType ContentType { get; init; }

        public ResivedMessageContent(byte[] content, ResivedMessageContentType contentType)
        {
            ByteContent = content;
            ContentType = contentType;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < ByteContent.Count(); i++)
            {
                if(i != 0)
                {
                    result.Append(" ");
                }
                result.Append($"0x{ByteContent[i]:X2}");
            }
            return result.ToString();
        }
    }
}
