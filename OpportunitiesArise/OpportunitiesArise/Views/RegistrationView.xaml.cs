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
    public partial class RegistrationView : ContentPage
    {
        public RegistrationView()
        {
            InitializeComponent();

            BindingContext = new RegistrationView();
        }


        private void OnSignUpButtonClicked(object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new RegistrationView());

        }


    }
}