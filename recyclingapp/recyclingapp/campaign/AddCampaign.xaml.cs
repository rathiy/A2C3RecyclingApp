using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace recyclingapp.campaign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCampaign : ContentPage
    {
        public AddCampaign()
        {
            InitializeComponent();
        }

        private async void BtnSubmit_Clicked(object sender, EventArgs e)
        {
            //var user = (Models.UserRegistration)BindingContext;
            var mycamp = new Models.campaign()
            {
                CampID = 0,
                campname = campname.Text,
                describtion = describtion.Text,
                datecreated = datecreated.Date.ToString(),
                address = address.Text,
            };
            //user.Username = DateTime.UtcNow;
            await App.Database.SaveCampaignAsync(mycamp);
            // await Navigation.PopAsync();

            await Navigation.PushAsync(new ViewAllCampaign());
        }
        private async void Show_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewAllCampaign());
        }


    }
}