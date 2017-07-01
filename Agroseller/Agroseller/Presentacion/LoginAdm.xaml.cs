using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agroseller.Negocio;
using Agroseller.Datos;
using Agroseller.Presentacion;


namespace Agroseller.Presentacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginAdm : TabbedPage
	{
        string userT;
		public LoginAdm (string user)
		{
			InitializeComponent ();
            userT = user;
            LabelAdm.Text = "Bienvenido " +user.ToString();
		}

        private async void Inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginAdm(userT));
        }
        private async void Salir_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Cliente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PackAdministrarCliente());
            
        }

        private async void Administrador_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PackAdministrarAdministrador());

        }

        private async void Agente_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PackAdministrarAgente());
        }
    }
}