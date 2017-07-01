using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    public class DSexo
    {
        public int id;
        public string descripcion;

        public DSexo()
        {

        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public int GetId()
        {
            return this.id;
        }
        public string GetDescripcion()
        {
            return this.descripcion;
        }

        public async Task<List<string>> Listar_Sexo()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/ListarSexo.php";
            return await res.Listar_Sexo(url);
        }
    }
}
