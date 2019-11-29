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
    public partial class ViewAllCampaign : ContentPage
    {
        public ViewAllCampaign()
        {
            InitializeComponent();
            BindAllCampaign();
        }
        public async void BindAllCampaign()
        {
            var list = await App.Database.GetCampaignAsync();
            listBindAll.ItemsSource = list;
        }

        private async void listview_selctedItem(object sender, SelectedItemChangedEventArgs e)
        {

            var obj = (recyclingapp.Models.campaign)e.SelectedItem;
            var ide = Convert.ToInt32(obj.CampID);
            int IdInt =Convert.ToInt32(ide);
            var data = (sender as ListView).SelectedItem as ViewAllCampaign;
            recyclingapp.Models.campaign param = await App.Database.GetSingleCampaignAsync(IdInt);
            Navigation.PushAsync(new ViewSelectedCampaign(param));
        }

        private async void btn_add_campaign_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCampaign());
        }
    }
}