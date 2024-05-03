using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class ProductPageViewModel:BaseProductViewModel
    {
        [ICommand]
        private async void OnAddProduct()
        {
            await Shell.Current.GoToAsync(nameof(AddProductPage));
        }
    }
}
