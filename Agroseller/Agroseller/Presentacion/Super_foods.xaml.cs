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
	public partial class Super_foods : ContentPage
	{
        NProducto nProducto;

		public Super_foods ()
		{
			InitializeComponent ();
            nProducto = new NProducto();
            List<string> aa = new List<string>();

            Task.Run(async () => aa = await nProducto.ListarSuperFoods()).Wait();

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

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {

        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
