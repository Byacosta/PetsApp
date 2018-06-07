using PetsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PetsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccount : ContentPage
	{
		public CreateAccount ()
		{
			InitializeComponent ();
		}

        public void CreateUser(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nameUser.Text) || String.IsNullOrEmpty(password.Text) ||
                String.IsNullOrEmpty(address.Text) || String.IsNullOrEmpty(phone.Text) ||
                String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(sex.SelectedItem.ToString()))
            {

                DisplayAlert("Error", "Complet Of Formlation", "OK");
            }
            else
            {

                //   crear objeto del modelo tarea
                Usuario usuario = new Usuario()
                {
                    NameUser = nameUser.Text,
                    Password = password.Text,
                    Address = address.Text,
                    Phone = phone.Text,
                    Email = email.Text,
                    Sex = sex.SelectedItem.ToString()
                };

                // conexion a la base de datos
                using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(App.urlBd))
                {
                    // crear tabla en base de datos
                    connection.CreateTable<Usuario>();

                    // crear registro en la tabla
                    var result = connection.Insert(usuario);

                    if (result > 0)
                    {
                        DisplayAlert("Correcto", "The user created correctly", "OK");
                        NextHome();
                    }
                    else
                    {
                        DisplayAlert("Incorrecto", "The User was not created", "OK");
                    }
                }
            }

        }

        async public void to_return(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async public void NextHome()
        {
            await Navigation.PushAsync(new Home());
        }

    }
}