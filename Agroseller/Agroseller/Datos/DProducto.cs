using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    public class DProducto
    {
        private int id;
        private string nombre;
        private string url_image;
        private int id_familia;
        
        public DProducto()
        {

        }

        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetNombre(string nom)
        {
            this.nombre = nom;
        }
        public void SetUrl_image(string url)
        {
            this.url_image = url;
        }
        public void SetId_famila(int id)
        {
            this.id_familia = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetUrl_image()
        {
            return this.url_image;
        }
        public int GetId_familia()
        {
            return this.id_familia;
        }

        public async Task<List<string>> ListarConsumoAnimal()
        {
            RestClient client = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/ListarConsumoAnimal.php";
            return await client.Get_Producto(url);
            
        }
        public async Task<List<string>> ListarSuperFoods()
        {
            RestClient client = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/ListarSuperFoods.php";
            return await client.Get_Producto(url);

        }

    }
}
