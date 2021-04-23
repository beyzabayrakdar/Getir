using Getir.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Getir.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class girisYapPage : ContentPage
    {
        public girisYapPage()
        {
            InitializeComponent();
        }

        void SignInProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_EPosta.Text, Entry_Password.Text);
            if (user.CheckInformation())
            {
                DisplayAlert("Login", "Login Success", "Okey");
            }
            else
            {
                DisplayAlert("Login", "Login Not Correct, empty username or password", "Okey");
            }
        }

        private async void AboutPage_CLicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }
    }
}