using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.Model;
using PS_PreslavDrakov.View;
using System.Collections.ObjectModel;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class ProductPageViewModel : BaseProductViewModel
    {
        public ObservableCollection<Product> productList { get; set; }
        public ProductPageViewModel(INavigation navigation)
        {
            productList = new ObservableCollection<Product>();
            Navigation=navigation;
        }

        [ICommand]
        private async void OnAddProduct()
        {
            await Shell.Current.GoToAsync(nameof(AddProductPage));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        [ICommand]
        private async Task LoadProduct()
        {
            IsBusy = true;
            try
            {
                productList.Clear();
                var prodList=await App.ProductService.GetProductsAsync();
                foreach (var item in prodList)
                {
                    productList.Add(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }
        [ICommand]
        private async void ProductTappedDelete(Product prodInfo)
        {
            if (prodInfo == null)
                return;
            await App.ProductService.DeleteProductAsync(prodInfo.ProdId);
            await LoadProduct();
            OnAppearing();
        }

        [ICommand]
        private async void ProductTappedEdit(Product prodInfo)
        {
            if (prodInfo == null)
                return;
            await Navigation.PushAsync(new AddProductPage(prodInfo));
        }
        
    }
}
