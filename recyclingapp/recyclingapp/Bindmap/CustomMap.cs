using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
namespace recyclingapp.Bindmap
{
    public class CustomMap : Map
    {
        Polyline polyline = null;

        public BindableProperty RouteCoordinatesProperty = BindableProperty.Create(
                                    propertyName: "RouteCoordinates",
                                    returnType: typeof(List<GeoPosition>),
                                    declaringType: typeof(CustomMap),
                                    defaultValue: new List<GeoPosition>(),
                                    defaultBindingMode: BindingMode.TwoWay);

        protected override void OnPropertyChanged(string propertyName = null)
        {
            UpdateRoute();
        }

        /// <summary>
        /// Gets or sets the points.
        /// </summary>
        /// <value>The points.</value>
        public List<GeoPosition> RouteCoordinates
        {
            get { return (List<GeoPosition>)base.GetValue(RouteCoordinatesProperty); }
            set
            {
                base.SetValue(RouteCoordinatesProperty, value);
                UpdateRoute();
            }
        }

        void CenterMap()
        {
            if (RouteCoordinates.Count > 0)
            {
                int index = RouteCoordinates.Count / 2;
                MoveToRegion(MapSpan.FromCenterAndRadius(
                    new Position(RouteCoordinates[index].Latitude, RouteCoordinates[index].Longitude),
                    Distance.FromMiles(1.0)));
            }
        }

        void UpdateRoute()
        {
            if (RouteCoordinates.Count > 2)
            {
                polyline = new Polyline();
                foreach (GeoPosition p in RouteCoordinates)
                    polyline.Positions.Add(new Position(p.Latitude, p.Longitude));

                Polylines.Add(polyline);
                CenterMap();
            }
        }
    }
    public class GeoPosition
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GeoPosition(double lat, double lon)
        {
            Latitude = lat;
            Longitude = lon;
        }
    }
}
