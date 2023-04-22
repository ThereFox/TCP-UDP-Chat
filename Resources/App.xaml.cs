using TCP_UDPClient.ViewModel;

namespace TCP_UDPClient_;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell()
		{
			BindingContext = new ChatViewModel()
		};
	}
}
