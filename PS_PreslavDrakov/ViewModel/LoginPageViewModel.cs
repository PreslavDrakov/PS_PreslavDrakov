using PS_PreslavDrakov.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PS_PreslavDrakov.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using PS_PreslavDrakov.View;

namespace PS_PreslavDrakov.ViewModel
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        readonly ILoginRepository loginRepository = new LoginService();

        [ICommand]
        public async void Login()
        {
            if(!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password))
            {
                UserInfo userInfo = await loginRepository.Login(UserName, Password);
                if (Preferences.ContainsKey(nameof(App.UserInfo)))
                {
                    Preferences.Remove(nameof(App.UserInfo));
                }
                string userDetails=JsonConvert.SerializeObject(userInfo);
                Preferences.Set(nameof(App.UserInfo), userDetails);
                App.UserInfo=userInfo;
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
