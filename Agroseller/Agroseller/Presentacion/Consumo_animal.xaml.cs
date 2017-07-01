using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Agroseller.Negocio;

namespace Agroseller.Presentacion
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Consumo_animal : ContentPage
	{
        NProducto nProducto;

        List<string> aa;

        public Consumo_animal()
        {
            InitializeComponent();

            nProducto = new NProducto();
            aa = new List<string>();

            Task.Run(async () => aa = await nProducto.ListarConsumoAnimal()).Wait();

            List<InfoList.ListaProducto> exa = new List<InfoList.ListaProducto>();
            int i = 0;
            while (i < aa.Count)
            {
                InfoList.ListaProducto pp = new InfoList.ListaProducto();
                pp.Descripcion2 = aa[i];
                i++;
                pp.Foto2 = aa[i];
                i++;
                exa.Add(pp);
            }

            ListaProducto.ItemsSource = exa;
        }

        private void ProductoSearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
        }

        private void ProductoSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<string> aux = new List<string>();
            var keyword = ProductoSearchBar.Text;
            int i = 0;
            while (i < aa.Count)
            {
                aux.Add(aa[i]);
                i = i + 2;
            }
            var suggestion = aux.Where(c => c.ToLower().Contains(keyword.ToLower()));
            //var s = from c in aa where c.Contains(keyword) select c;

            ListaProducto.ItemsSource = suggestion;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
