using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace recyclingapp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void user_log_btn_Clicked(object sender, EventArgs e)
        {
            //var user = (Models.UserRegistration)BindingContext;
            var user = new Models.UserRegistration()
            {
                Username = username_txt.Text,
               
                Password = password_txt.Text,
            };
            //user.Username = DateTime.UtcNow;
            var _user = await App.Database.LoginUserAsync(user.Username, user.Password);
            if (_user != null)
            {
                await Navigation.PushAsync(new Page1());
            }
            else
            {

                await DisplayAlert("Required", "Invalid User Details", "OK");

            }
            //await Navigation.PopAsync();
        }
    }
}