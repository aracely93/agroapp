using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    class DFamilia
    {
        private int id;
        private string descripcion;
        private string url_image;
        private int id_familia;

        public DFamilia()
        {

        }
        
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetDescripcion(string des)
        {
            this.descripcion = des;
        }
        public void SetUrl_image(string url)
        {
            this.url_image = url;
        }
        public void SetId_familia(int id)
        {
            this.id_familia = id;
        }

        public int GetId()
        {
            return this.id;
        }
        public string GetDescripcion()
        {
            return this.descripcion;
        }
        public string GetUrl_image()
        {
            return this.url_image;
        }
        public int GetId_familia()
        {
            return this.id_familia;
        }
        


        public async Task<List<string>> ListarFamilia()
        {
            RestClient client = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/ListarFamilia.php?";
            return await client.Get_Familia(url);
            

        }

    }
}
