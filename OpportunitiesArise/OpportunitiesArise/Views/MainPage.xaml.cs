using Xamarin.Forms;
using OpportunitiesArise.ViewModels;
using OpportunitiesArise.Views;

namespace OpportunitiesArise
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

           
            BindingContext = new AddingInformation();

        } 
        public void RegistrationView()
        {
            BindingContext = new RegistrationView();

        }


        private  async void OnSignUpButtonClicked(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new RegistrationView());

        }


        private async void Button_Clicked(object sender, System.EventArgs e)
        {
           await Navigation.PushAsync(new Views.Page1());



        }
    }
}
