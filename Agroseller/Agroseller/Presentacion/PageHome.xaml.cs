using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agroseller.Negocio;
using Agroseller.Datos;
using Agroseller.Presentacion;

namespace Agroseller
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageHome : ContentPage
	{
        NLogin nLogin;
        int privilegio=0;

		public PageHome ()
		{
			InitializeComponent ();
            UserLabel.Text = "User: ";
            PasswordLabel.Text = "Password: ";
            PrivilegioLabel.Text = "Privilegio: ";

            PrivilegioPicker.Items.Add("Cliente");
            PrivilegioPicker.Items.Add("Administrador");
            PrivilegioPicker.Items.Add("Agente de ventas");

            nLogin = new NLogin();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            string user = UserEntry.Text;
            string pass = PasswordEntry.Text;

            
            if ((UserEntry.Text != string.Empty) &&  (PasswordEntry.Text != string.Empty) && (privilegio!=0))
            {
                string lista = await nLogin.BuscarLogin(user, pass,privilegio);
                string jjj = "ERROR ";

                if (string.Equals(lista, jjj, StringComparison.Ordinal))
                {
                    await DisplayAlert("Access Incorrect",
                    "Enter again your data",
                    "Ok");

                }
                else
                {
                    ResultLabel.Text = "Bienvenido...";
                    if (String.Equals(privilegio.ToString(), "1", StringComparison.Ordinal))
                    {
                        await Navigation.PushAsync(new LoginAdm(user));
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login(user));
                    }
                }


            }
            else
            {
                await DisplayAlert(" ",
                   "Complete your information..",
                   "Ok");
                return;

            }
        }

        private void PrivilegioPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aux=PrivilegioPicker.Items[PrivilegioPicker.SelectedIndex];
            if (String.Equals(aux.ToString(), "Cliente",StringComparison.Ordinal))
            {
                privilegio = 2;
            }
            else
            {
                privilegio = 1;
            }
        }
    }
}
