using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpportunitiesArise.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FlyOutView : ContentPage
    {
        private INavigation navigation;

        public FlyOutView()
        {
            InitializeComponent();
            BindingContext = new FlyOutView(Navigation);
        }

        public FlyOutView(INavigation navigation)
        {
            this.navigation = navigation;
        }
    }
}