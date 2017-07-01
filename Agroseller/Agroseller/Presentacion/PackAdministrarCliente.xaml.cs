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
	public partial class PackAdministrarCliente : ContentPage
	{
        NSexo nSexo;
        NCliente nCliente;

        int codigo = 0;
        string nombres = "";
        string apellidos = "";
        string direccion = "";
        string fecha = "";
        string telefono = "";
        int idSexo=0;


		public PackAdministrarCliente ()
		{
			InitializeComponent ();
            nSexo = new NSexo();
            nCliente = new NCliente();
            NotVisibleAdd();

            PickerSexo.Items.Add("Femenino");
            PickerSexo.Items.Add("Masculino");


        }

        public void VisibleAdd()
        {
            LabelCodigo.IsVisible = true;
            LabelNombres.IsVisible = true;
            LabelApellidos.IsVisible = true;
            LabelFechaNac.IsVisible = true;
            LabelDireccion.IsVisible = true;
            LabelTelefono.IsVisible = true;
            LabelSexo.IsVisible = true;
            ResultLabel.IsVisible = true;

            EntryCodigo.IsVisible = true;
            EntryNombres.IsVisible = true;
            EntryApellidos.IsVisible = true;
            EntryDireccion.IsVisible = true;
            EntryTelefono.IsVisible = true;

            PickerSexo.IsVisible = true;
            FechaPicker.IsVisible = true;

            ButtonAdd.IsVisible = true;
        }
        public void NotVisibleAdd()
        {
            LabelCodigo.IsVisible = false;
            LabelNombres.IsVisible = false;
            LabelApellidos.IsVisible = false;
            LabelFechaNac.IsVisible = false;
            LabelDireccion.IsVisible = false;
            LabelTelefono.IsVisible = false;
            LabelSexo.IsVisible = false;
            ResultLabel.IsVisible = false;

            EntryCodigo.IsVisible = false;
            EntryNombres.IsVisible = false;
            EntryApellidos.IsVisible = false;
            EntryDireccion.IsVisible = false;
            EntryTelefono.IsVisible = false;

            PickerSexo.IsVisible = false;
            FechaPicker.IsVisible = false;

            ButtonAdd.IsVisible = false;
        }

        public void ClearEntry()
        {
            EntryCodigo.Text="";
            EntryNombres.Text="";
            EntryApellidos.Text="";
            EntryDireccion.Text="";
            EntryTelefono.Text="";
            
        }


        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            fecha = e.NewDate.ToString();

        }

        private  void PickerSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var aux = PickerSexo.Items[PickerSexo.SelectedIndex];
            if (String.Equals(aux.ToString(), "Femenino", StringComparison.Ordinal))
            {
                idSexo = 1;
            }
            else
            {
                idSexo = 2;
            }

        }

       

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Add";
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Search";
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Edit";
        }

        private void ToolbarItem_Clicked_3(object sender, EventArgs e)
        {
            NotVisibleAdd();
            ButtonAdd.Text = "Show All";
        }

        private void ToolbarItem_Clicked_4(object sender, EventArgs e)
        {
            ClearEntry();
        }


        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {
            
            if (ButtonAdd.Text == "Add"){

                AddCliente();

            }else if (ButtonAdd.Text == "Search")
            {
                SearchCliente();

            }else if (ButtonAdd.Text == "Edit")
            {
                EditCliente();

            }else if(ButtonAdd.Text=="Show All")
            {

            }

        }


        public async void AddCliente()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            nombres = EntryNombres.Text.ToString();
            apellidos = EntryApellidos.Text.ToString();
            direccion = EntryDireccion.Text.ToString();
            telefono = EntryTelefono.Text.ToString();

            int res = await nCliente.Insertar_Cliente(codigo, nombres, apellidos, direccion,
                fecha, telefono, idSexo);
            if (res != -1)
            {
                await DisplayAlert("Insert Cliente", "Successfull Insert", "OK");
            }
            else
            {
                await DisplayAlert("Insert Cliente", "Error Insert", "OK");
            }
        }
        public async void SearchCliente()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            List<string> ress = await nCliente.Buscar_Cliente(codigo);
            if (ress.Count != 0)
            {
                EntryNombres.Text = ress[0];
                EntryApellidos.Text = ress[1];
                EntryDireccion.Text = ress[2];
                fecha =ress[3];
                FechaPicker.Date=DateTime.Parse(fecha);
                EntryTelefono.Text = ress[4];
                if (Int32.Parse(ress[5]) == 1)
                {
                    PickerSexo.SelectedItem = "Femenino";
                }
                else
                {
                    PickerSexo.SelectedItem = "Masculino";
                }
            }
        }
        public async void EditCliente()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            nombres = EntryNombres.Text.ToString();
            apellidos = EntryApellidos.Text.ToString();
            direccion = EntryDireccion.Text.ToString();
            telefono = EntryTelefono.Text.ToString();

            int res = await nCliente.Edit_Cliente(codigo, nombres, apellidos, direccion,
                fecha, telefono, idSexo);
            if (res != -1)
            {
                await DisplayAlert("Successful Edit", "Successfull Insert", "OK");
            }
            else
            {
                await DisplayAlert("Error edit", "Error Insert", "OK");
            }
        }
        
    }
}