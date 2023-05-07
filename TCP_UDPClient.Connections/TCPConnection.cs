using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using TCP_UDPClient.Model;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.Connections
{
    public class TCPConnection : IProtocolConnection
    {
        private TcpClient _client;
        private BackgroundWorker _worker = new();
        private UserIdentity _selectedUser;
        private UserIdentity _currentUser;

        private byte[] buffer = new byte[512];

        public TCPConnection(IPAddress connectingIp, int port, IPAddress userIP)
        {
            var endpoint = new IPEndPoint(connectingIp, port);
            _client = new TcpClient(endpoint);
            _selectedUser = new UserIdentity(connectingIp);
            _currentUser = new UserIdentity(connectingIp);

            _worker.DoWork += (sender, args) => ReceiveRuntime();
            _worker.RunWorkerAsync();
        }

        private async Task ReceiveRuntime()
        {
            while(true)
            {
                await _client.GetStream().ReadAsync(buffer, 0, 512);

                var messageInfo = new ResivedMessageInfo(_selectedUser, _currentUser);
                var messageContent = new ResivedMessageContent(buffer[0..(buffer[3])], ResivedMessageContentType.bytes);
                var message = new ResivedMessage(messageInfo, messageContent);

                GetNewMessage(message);
            }
        }

        public event Action<ResivedMessage> GetNewMessage;

        public void Send(SendingMessage message)
        {
            var data = message.FormatMessage();
            _client.GetStream().WriteAsync(data);
        }
    }
}
