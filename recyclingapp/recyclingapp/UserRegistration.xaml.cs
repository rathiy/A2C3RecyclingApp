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
    public partial class UserRegistration : ContentPage
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private async void user_register_btn_Clicked(object sender, EventArgs e)
        {
            //var user = (Models.UserRegistration)BindingContext;
            var user = new Models.UserRegistration()
            {
                Username = username_txt.Text,
                Email = email_txt.Text,
                Password = password_txt.Text,
            };
            //user.Username = DateTime.UtcNow;
            await App.Database.SaveUserRegistrationAsync(user);
            await Navigation.PopAsync();
        }
    }
}