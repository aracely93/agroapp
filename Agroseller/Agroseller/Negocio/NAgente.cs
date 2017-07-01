using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NAgente
    {
        DAgente dAgente;

        public NAgente()
        {
            this.dAgente = new DAgente();
        }
        
        public async Task<int> Insertar_Agente(int cod, string nom, string apel, int ci,
            string tele, int id_sex)
        {
            dAgente.SetCodigo(cod);
            dAgente.SetNombre(nom);
            dAgente.SetApellidos(apel);
            dAgente.SetCi(ci);
            dAgente.SetTelefono(tele);
            dAgente.SetId_Sexo(id_sex);

            return await dAgente.Insertar_Agente();
        }
        public async Task<List<string>> Buscar_Agente(int codigo)
        {
            dAgente.SetCodigo(codigo);
            return await dAgente.Buscar_Agente();
        }
        public async Task<int> Edit_Agente(int cod, string nom, string apel, int ci,
            string tele, int id_sex)
        {
            dAgente.SetCodigo(cod);
            dAgente.SetNombre(nom);
            dAgente.SetApellidos(apel);
            dAgente.SetCi(ci);
            dAgente.SetTelefono(tele);
            dAgente.SetId_Sexo(id_sex);

            return await dAgente.Edit_Agente();
        }
    }
}
 