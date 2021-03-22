using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

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

       private void Button_Clicked(object sender, EventArgs e, object EntryUserPassword, object EntryUserName, object EntryUserEmail, object EntryUserPhoneNumber)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Userdatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new UserRegTable()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Numeric,
            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {

                var result = await this.DisplayAlert("Congratulations", "You have been Registered", "Yes", "Cancel");

            });
        }
    }
}