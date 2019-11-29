using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace recyclingapp.recyclingcentres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddRecyclingCentres : ContentPage
    {
        public AddRecyclingCentres()
        {
            InitializeComponent();
          
        }

        private async void AddRecyclingbtn_Clicked(object sender, EventArgs e)
        {
            var recycling_centre = new Models.Recyclingcentre()
            {
                RcID = 0,
                Recycling = Recycling.Text,
                datecreated = datecreated.Date.ToString(),
                Adress = $"{ address1.Text} { address2.Text}",
                Keyword = keyword.Text,
                langitute = longitude.Text,
                latitute = latitude.Text,
            };
            //user.Username = DateTime.UtcNow;
            await App.Database.SaveRecyclingAsync(recycling_centre);
            await DisplayAlert("Recycling Says", "added successfuly", "OK");
            await Navigation.PopAsync();
        }

        private async void ViewRecyclingbtn_Clicked(object sender, EventArgs e)
        {
           // var centres = await App.Database.GetRecylingAsync();
           // await DisplayAlert("Recycling Centres keywords", $"{ centres.FirstOrDefault().Keyword}", "OK");
        }
    }
}