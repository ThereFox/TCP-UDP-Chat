using TCP_UDPClient.ViewModel;
using TCP_UDPClient.ViewModel.Types;
using TCP_UDPClient.Model;
using TCP_UDPClient.Connections;
using System.Net;
using TCP_UDPClient.Model.Types.SendingMessage.SendingContent;
using TCP_UDPClient.Model.SendingTypes.Base;
using TCP_UDPClient.Model.SendingTypes.Encodings.BytesEncodings;

namespace TCP_UDPClient;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var userIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

		MainPage = new AppShell()
		{
			BindingContext = new ChatViewModel(
				
				new Avaliables(
						new Dictionary<string, IProtocolConnection>()
						{
							{ "TCP", new TCPConnection(IPAddress.Any, 3033, userIP) }
						},
						new Dictionary<string, ISendingContentType>()
						{
							{"ASCII", new ASCIISendingContent() },
							{"Bytes", new BytesSendingContent() }
						},
						new Dictionary<string, IByteEncoding>()
						{
							{"Без", new NullObjectEncoding() },
							{"Нировский FF протокол", new NirFFEncoding() }
						}

					)

				)
		};
	}
}
