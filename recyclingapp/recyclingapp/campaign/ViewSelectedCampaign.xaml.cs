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
    public partial class ViewSelectedCampaign : ContentPage
    {
        public ViewSelectedCampaign(recyclingapp.Models.campaign param)
        {
            InitializeComponent();
            BindCamapinDetails(param);


        }
        public async void BindCamapinDetails(recyclingapp.Models.campaign param)
        {

            lblcampname.Text = param.campname;
            lbldescription.Text = param.describtion;
            lblstartdate.Text = param.datecreated;
        }

    }
}