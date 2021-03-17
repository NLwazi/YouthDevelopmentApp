using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpportunitiesArise.Models.Services
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapServices : ContentPage
    {
        public MapServices()
        {
            InitializeComponent();
            {
                async Task NavigateToCampus()
            {
                    Location location1 = new Location(-33.839307345652095, 18.61017941893287);
                    var location = location1;
                //var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };
                var options = new MapLaunchOptions { NavigationMode = NavigationMode.Walking };


                    await Map.OpenAsync(location, options);
            }
        }

    }
    }
}