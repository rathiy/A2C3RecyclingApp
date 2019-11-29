using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;
namespace recyclingapp.recyclingcentres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSelectedRecy : ContentPage
    {
        public ViewSelectedRecy(recyclingapp.Models.Recyclingcentre param)
        {
            InitializeComponent();
            binMap(param);
        }

        public void binMap(recyclingapp.Models.Recyclingcentre param)
        {
            Map map = new Map
            {
                // ...
            };
            Pin pin = new Pin
            {
                Label = "Coventry University",
                Address = "Priory Street",
                Type = PinType.Place,
                Position = new Position(52.4071747, -1.5037461),

            };



            map.MoveToRegion(MapSpan.FromCenterAndRadius(pin.Position, Distance.FromMiles(0.3)));
            map.Pins.Add(pin);
        }
    }

}