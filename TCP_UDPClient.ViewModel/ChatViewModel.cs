using System.Windows.Input;
using TCP_UDPClient.Model;
using TCP_UDPClient.ViewModel.Types;

namespace TCP_UDPClient.ViewModel
{
    public class ChatViewModel
    {
        private ChatModel _model { get; init; } = new();

        public MessageCollection Messages { get; init; } = new();
        public WritingMessage WritingMessage { get; init; } = new();
        public WirelessSettings WirelessSettings { get; init; } = new();
        public Avaliables Avaliables { get; init; }

        public ChatViewModel(Avaliables avaliables)
        {
            Avaliables = avaliables;
        }

        public void SendMessage()
        {
            var message = Avaliables.GetMessage(WritingMessage);
            _model.Send(message);
        }
        private void messegeResivedHandler(ResivedMessage message)
        {
            Messages.AppendMessage(message);
        }
    }
}