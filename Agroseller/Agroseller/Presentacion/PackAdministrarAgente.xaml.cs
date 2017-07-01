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
	public partial class PackAdministrarAgente : ContentPage
	{
        NSexo nSexo;
        NAgente nAgente;

        int codigo = 0;
        string nombres = "";
        string apellidos = "";
        int ci = 0;
        string telefono = "";
        int idSexo = 0;

        public PackAdministrarAgente ()
		{
			InitializeComponent ();
            nSexo = new NSexo();
            nAgente = new NAgente();
            NotVisibleAdd();

            PickerSexo.Items.Add("Femenino");
            PickerSexo.Items.Add("Masculino");

        }
        public void VisibleAdd()
        {
            LabelCodigo.IsVisible = true;
            LabelNombres.IsVisible = true;
            LabelApellidos.IsVisible = true;
            LabelCi.IsVisible = true;
            LabelTelefono.IsVisible = true;
            LabelSexo.IsVisible = true;
            ResultLabel.IsVisible = true;

            EntryCodigo.IsVisible = true;
            EntryNombres.IsVisible = true;
            EntryApellidos.IsVisible = true;
            EntryCi.IsVisible = true;
            EntryTelefono.IsVisible = true;

            PickerSexo.IsVisible = true;
            ButtonAdd.IsVisible = true;
        }
        public void NotVisibleAdd()
        {
            LabelCodigo.IsVisible = false;
            LabelNombres.IsVisible = false;
            LabelApellidos.IsVisible = false;
            LabelCi.IsVisible = false;
            LabelTelefono.IsVisible = false;
            LabelSexo.IsVisible = false;
            ResultLabel.IsVisible = false;

            EntryCodigo.IsVisible = false;
            EntryNombres.IsVisible = false;
            EntryApellidos.IsVisible = false;
            EntryCi.IsVisible = false;
            EntryTelefono.IsVisible = false;

            PickerSexo.IsVisible = false;

            ButtonAdd.IsVisible = false;
        }

        public void ClearEntry()
        {
            EntryCodigo.Text = "";
            EntryNombres.Text = "";
            EntryApellidos.Text = "";
            EntryCi.Text = "";
            EntryTelefono.Text = "";

        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Add";
        }

        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Search";

        }

        private void ToolbarItem_Clicked_3(object sender, EventArgs e)
        {
            VisibleAdd();
            ButtonAdd.Text = "Edit";
        }

        private void ToolbarItem_Clicked_4(object sender, EventArgs e)
        {
            NotVisibleAdd();
            ButtonAdd.Text = "Show All";
        }

        private void PickerSexo_SelectedIndexChanged(object sender, EventArgs e)
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
        private void ButtonAdd_Clicked(object sender, EventArgs e)
        {

            if (ButtonAdd.Text == "Add")
            {
                AddAdministrador();
            }
            else if (ButtonAdd.Text == "Search")
            {
                SearchAdministrador();
            }
            else if (ButtonAdd.Text == "Edit")
            {
                EditAdministrador();
            }
            else if (ButtonAdd.Text == "Show All")
            {

            }

        }

        public async void AddAdministrador()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            nombres = EntryNombres.Text.ToString();
            apellidos = EntryApellidos.Text.ToString();
            ci = Int32.Parse(EntryCi.Text.ToString());
            telefono = EntryTelefono.Text.ToString();

            int res = await nAgente.Insertar_Agente(codigo, nombres, apellidos, ci, telefono, idSexo);
            if (res != -1)
            {
                await DisplayAlert("Insert Administrador", "Successfull Insert", "OK");
            }
            else
            {
                await DisplayAlert("Insert Administrador", "Error Insert", "OK");
            }
        }
        public async void SearchAdministrador()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            List<string> ress = await nAgente.Buscar_Agente(codigo);
            if (ress.Count != 0)
            {
                EntryNombres.Text = ress[0];
                EntryApellidos.Text = ress[1];
                EntryCi.Text = ress[2];
                EntryTelefono.Text = ress[3];
                if (Int32.Parse(ress[4]) == 1)
                {
                    PickerSexo.SelectedItem = "Femenino";
                }
                else
                {
                    PickerSexo.SelectedItem = "Masculino";
                }
            }
        }
        public async void EditAdministrador()
        {
            codigo = Int32.Parse(EntryCodigo.Text);
            nombres = EntryNombres.Text.ToString();
            apellidos = EntryApellidos.Text.ToString();
            ci = Int32.Parse(EntryCi.Text.ToString());
            telefono = EntryTelefono.Text.ToString();

            int res = await nAgente.Edit_Agente(codigo, nombres, apellidos, ci, telefono, idSexo);
            if (res != -1)
            {
                await DisplayAlert("Succefull Edit", "Successfull Insert", "OK");
            }
            else
            {
                await DisplayAlert("Error Edit", "Error Insert", "OK");
            }
        }
    }
}