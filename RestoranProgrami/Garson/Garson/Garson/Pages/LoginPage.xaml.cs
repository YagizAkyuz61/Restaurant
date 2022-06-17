using Garson.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Garson.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            nickTXT.Text = Preferences.Get("waiterNick", string.Empty);
            passTXT.Text = Preferences.Get("waiterPass", string.Empty);
        }

        private async void loginBTN_Clicked(object sender, EventArgs e)
        {
            var response = await ApiService.Login(nickTXT.Text, passTXT.Text);
            if(response)
            {
                Application.Current.MainPage = new NavigationPage(new OrderPage());
                Preferences.Set("waiterNick", nickTXT.Text);
                Preferences.Set("waiterPass", passTXT.Text);
            }
        }
    }
}