using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PetsApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (Application.Current.Properties.ContainsKey("user"))
            {
                ShowWindowWelcome();
            }
        }

        private void ClickButtonSignIn(object sender, EventArgs e)
        {
            if (entryUser.Text == "Pets" && entryPass.Text == "App")
            {
                Application.Current.Properties["user"] = entryUser.Text;
                ShowWindowWelcome();
            }
            else
            {
                DisplayAlert("Error", "Username does not exist", "OK");
            }
        }

        async private void ShowWindowWelcome()
        {
            await Navigation.PushModalAsync(new Home());
            entryUser.Text = "";
            entryPass.Text = "";
        }


        async private void NextCreateAccount(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreateAccount());
            entryUser.Text = "";
            entryPass.Text = "";
        }

    }
}
