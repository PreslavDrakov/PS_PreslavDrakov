using PS_PreslavDrakov.Model;
using PS_PreslavDrakov.ViewModel;

namespace PS_PreslavDrakov.View;

public partial class AddProductPage : ContentPage
{
	public Product ProductInfo { get; set; }
	public AddProductPage()
	{
		InitializeComponent();
		this.BindingContext = new AddProductPageViewModel();
	}
}