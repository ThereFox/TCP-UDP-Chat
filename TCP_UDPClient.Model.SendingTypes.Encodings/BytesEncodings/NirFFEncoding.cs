using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;

namespace TCP_UDPClient.Model.SendingTypes.Encodings.BytesEncodings
{
    public class NirFFEncoding : IByteEncoding
    {
        public byte[] Encode(byte[] data)
        {
            var result = new byte[data.Length + 5];
            putProtocolHead(result);
            putContent(result, data);
            putCRC(result);
            putFFPosition(result);
            return result;
        }
        private void putProtocolHead(byte[] result)
        {
            result[0] = 0xff;
            result[1] = 0x01;
            result[2] = (byte)result.Length;
            result[3] = 0x00;
        }
        private void putContent(byte[] result, byte[] content)
        {
            content.CopyTo(result, 4);
        }
        private void putCRC(byte[] result)
        {
            result[result.Length - 1] = getCRC(result);
        }
        private byte getCRC(byte[] data)
        {
            var sum = data.Sum(x => x);
            var crc = (byte)(sum & 0xff);
            return crc;
        }
        private void putFFPosition(byte[] data)
        {
            if(haveFF(data) == false)
            {
                return;
            }
            var indexes = getFFIndexes(data);
            data[3] = (byte)(indexes.First() - 3);
            data[indexes.Last()] = 0x00;

            for (int i = indexes.Length; i > 1; i++)
            {
                var previousIndex = indexes[i - 1];
                var currentIndex = indexes[i];

                data[previousIndex] = (byte)(currentIndex - previousIndex);
            }
        }

        private int[] getFFIndexes(byte[] data)
        {
            var result = new List<int>();
            for (int i = 4; i < data.Length; i++)
            {
                if (data[i] == 0xff)
                {
                    result.Add(data[i]);
                }
            }
            return result.ToArray();
        }

        private bool haveFF(byte[] data)
        {
            return data.Any(x => x == 0xff);
        }

    }
}
