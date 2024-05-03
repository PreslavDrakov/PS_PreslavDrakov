using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class AddProductPageViewModel:BaseProductViewModel
    {
        public AddProductPageViewModel()
        {
            Product = new Product();
        }

        [ICommand]
        public async void SaveProduct()
        {
            var product = Product;
            await App.ProductService.AddUpdateProductAsync(product);
            await Shell.Current.GoToAsync("..");
        }

        [ICommand]
        public async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
