using Microsoft.Toolkit.Mvvm.ComponentModel;
using PS_PreslavDrakov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class BaseProductViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Product _product;

        public INavigation Navigation { get; set; }

    }
}
