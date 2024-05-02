using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class AppShellViewModel:BaseViewModel
    {
        [ICommand]
        async void SignOut()
        {
            /*if (Preferences.ContainsKey(nameof(App.UserInfo)))
            {
                Preferences.Remove(nameof(App.UserInfo));
            }*/
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
