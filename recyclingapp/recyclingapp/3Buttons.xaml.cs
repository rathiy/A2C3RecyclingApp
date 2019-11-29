using recyclingapp.recyclingcentres;
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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private async void user_camp_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new campaign.ViewAllCampaign());
        }

        private async void user_rec_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewAllRecycling());

        }
        private async void user_disc_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserRegistration());

        }
    }
}