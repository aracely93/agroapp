using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NCliente
    {
        DCliente dCliente;

        public NCliente()
        {
            this.dCliente = new DCliente();
        }
        public async Task<int> Insertar_Cliente(int cod,string nom, string apel,string dire,
            string fecha_na,string tele, int id_sex)
        {
            dCliente.SetCodigo(cod);
            dCliente.SetNombre(nom);
            dCliente.SetApellidos(apel);
            dCliente.SetDireccion(dire);
            dCliente.SetFecha_Nac(fecha_na);
            dCliente.SetTelefono(tele);
            dCliente.SetId_Sexo(id_sex);

            return await dCliente.Insertar_Cliente();
        }
        public async Task<List<string>> Buscar_Cliente(int codigo)
        {
            dCliente.SetCodigo(codigo);
            return await dCliente.Buscar_Cliente();
        }
        public async Task<int> Edit_Cliente(int cod, string nom, string apel, string dire,
            string fecha_na, string tele, int id_sex)
        {
            dCliente.SetCodigo(cod);
            dCliente.SetNombre(nom);
            dCliente.SetApellidos(apel);
            dCliente.SetDireccion(dire);
            dCliente.SetFecha_Nac(fecha_na);
            dCliente.SetTelefono(tele);
            dCliente.SetId_Sexo(id_sex);

            return await dCliente.Edit_Cliente();
        }
    }
}
