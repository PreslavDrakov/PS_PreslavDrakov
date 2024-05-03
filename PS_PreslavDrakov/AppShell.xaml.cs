using PS_PreslavDrakov.View;
using PS_PreslavDrakov.ViewModel;

namespace PS_PreslavDrakov
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
            Routing.RegisterRoute(nameof(AddProductPage), typeof(AddProductPage));
        }
    }
}
