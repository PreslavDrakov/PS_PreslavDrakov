using PS_PreslavDrakov.Model;

namespace PS_PreslavDrakov
{
    public partial class App : Application
    {
        public static UserInfo UserInfo;
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
