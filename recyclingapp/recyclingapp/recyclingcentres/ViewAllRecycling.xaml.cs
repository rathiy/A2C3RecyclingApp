using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace recyclingapp.recyclingcentres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewAllRecycling : ContentPage
    {
        public ViewAllRecycling()
        {
            InitializeComponent();
            BindAllRecy();
        }
        public async void BindAllRecy()
        {
            var list = await App.Database.GetRecylingAsync();
            if (list.Count > 0)
            {
                listBindAll.ItemsSource = list;
            }
            else
            {
                lblnorecy.IsVisible = true;
            }

        }
        private async void listview_selctedItem(object sender, SelectedItemChangedEventArgs e)
        {

            var obj = (recyclingapp.Models.Recyclingcentre)e.SelectedItem;
            var ide = Convert.ToInt32(obj.RcID);
            int IdInt = Convert.ToInt32(ide);
            var data = (sender as ListView).SelectedItem as ViewAllRecycling;
            recyclingapp.Models.Recyclingcentre param = await App.Database.GetSingleRecyclingAsync(IdInt);
            Navigation.PushAsync(new ViewSelectedRecy(param));
        }

        private async void btn_add_recy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecyclingCentres());
        }
    }
}