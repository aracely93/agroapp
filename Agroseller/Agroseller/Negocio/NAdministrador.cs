using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NAdministrador
    {
        DAdministrador dAdministrador;
        
        public NAdministrador()
        {
            dAdministrador = new DAdministrador();
        }
        public async Task<int> Insertar_Administrador(int cod, string nom, string apel, int ci,
            string tele, int id_sex)
        {
            dAdministrador.SetCodigo(cod);
            dAdministrador.SetNombre(nom);
            dAdministrador.SetApellidos(apel);
            dAdministrador.SetCi(ci);
            dAdministrador.SetTelefono(tele);
            dAdministrador.SetId_Sexo(id_sex);

            return await dAdministrador.Insertar_Administrador();
        }
        public async Task<List<string>> Buscar_Administrador(int codigo)
        {
            dAdministrador.SetCodigo(codigo);
            return await dAdministrador.Buscar_Administrador();
        }
        public async Task<int> Edit_Administrador(int cod, string nom, string apel, int ci,
            string tele, int id_sex)
        {
            dAdministrador.SetCodigo(cod);
            dAdministrador.SetNombre(nom);
            dAdministrador.SetApellidos(apel);
            dAdministrador.SetCi(ci);
            dAdministrador.SetTelefono(tele);
            dAdministrador.SetId_Sexo(id_sex);

            return await dAdministrador.Edit_Administrador();
        }
    }
}
