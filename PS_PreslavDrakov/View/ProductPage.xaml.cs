using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.ViewModel;

namespace PS_PreslavDrakov.View;

public partial class ProductPage : ContentPage
{
	ProductPageViewModel productPageViewModel;
	public ProductPage()
	{
		InitializeComponent();
		this.BindingContext=productPageViewModel=new ProductPageViewModel();
	}
	
}