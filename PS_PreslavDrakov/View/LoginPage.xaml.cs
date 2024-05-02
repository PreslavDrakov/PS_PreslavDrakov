using PS_PreslavDrakov.ViewModel;

namespace PS_PreslavDrakov.View;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel loginPageViewModel)
	{
		InitializeComponent();
		this.BindingContext = loginPageViewModel;
	}
}