using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Agroseller.Negocio;
using Agroseller.Datos;
using System.Net.Http;
using Microsoft.Bot.Connector;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.Bot.Connector.DirectLine;
using Agroseller.Presentacion;

namespace Agroseller
{
	public partial class MainPage : ContentPage
	{
        /*
        private string conversationId;
        private string token;
        private HttpClient _httpClient;*/

       public MainPage()
		{
            
			InitializeComponent();
                       
            
            ImageAgro.ItemsSource = new List<InfoList.Bienvenido>
            {
                //lista[0],lista[1]
                new InfoList.Bienvenido
                {
                    Foto2="http://tallerproyect.hol.es/Main_Bienvenidos.png"
                }
            };

        }
        
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageHome());
        }
        private async void Connection(object sender, EventArgs e)
        {
          //  await Navigation.PushAsync(new Robot());
        }
    }
}
