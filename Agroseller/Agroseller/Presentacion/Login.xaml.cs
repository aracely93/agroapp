using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agroseller.Negocio;
using Agroseller.Datos;
using Agroseller.Presentacion;


namespace Agroseller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        NFamilia nFamilia;


        public Login(string user)
        {

            InitializeComponent();
            LoginLabel.Text = "BIENVENIDO " + "'" + user.ToString() + "'";

            nFamilia = new NFamilia();
            List<string> aa = new List<string>();

            Task.Run(async () => aa = await nFamilia.ListarFamilia()).Wait();

            List<InfoList.ListaFamilia> exa = new List<InfoList.ListaFamilia>();
            int i = 0;
            while (i < aa.Count)
            {
                InfoList.ListaFamilia pp = new InfoList.ListaFamilia();
                pp.Descripcion2 = aa[i];
                i++;
                pp.Foto2 = aa[i];
                i++;
                exa.Add(pp);
            }

            ListaFamilia.ItemsSource = exa;
            /*
            ListaFamilia.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                DisplayAlert("ItemSelecet", e.SelectedItem.ToString(), "OK");

            };
            */
        }


        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem; ;

             Console.WriteLine(item.ToString() + "   this is");
             if (String.Equals(item.ToString(),"Super Foods",StringComparison.Ordinal))
             {
                await Navigation.PushAsync(new Super_foods());
                 
             }
             else
             {
                await Navigation.PushAsync(new Consumo_animal());
               //  await Navigation.PushAsync(new Super_foods());
             }

        }

        

        private  void Button_Clicked(object sender, EventArgs e)
        {
            /*

            DisplayAlert("Notificacion",
                 "Do you want to save your password",
                 "Save",
                 "Don´t save");*/

        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //clic Inicio
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            //clic Salir
        }
    }

}
