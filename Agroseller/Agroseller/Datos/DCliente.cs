using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    public class DCliente
    {
        int codigo;
        string nombres;
        string apellidos;
        string direccion;
        string fecha_nac;
        string telefono;
        int id_sexo;

        public void SetCodigo(int cod)
        {
            this.codigo = cod;
        }
        public void SetNombre(string nom)
        {
            this.nombres = nom;
        }
        public void SetApellidos(string ap)
        {
            this.apellidos = ap;
        }
        public void SetDireccion(string dir)
        {
            this.direccion = dir;
        }
        public void SetFecha_Nac(string fec)
        {
            this.fecha_nac = fec;
        }
        public void SetTelefono(string tel)
        {
            this.telefono = tel;
        }
        public void SetId_Sexo(int id)
        {
            this.id_sexo = id;
        }
        public int GetCodigo()
        {
            return this.codigo;
        }
        public string GetNombre()
        {
            return this.nombres;
        }
        public string GetApellido()
        {
            return this.apellidos;
        }
        public string GetDireccion()
        {
            return this.direccion;
        }
        public string GetFecha_Nac()
        {
            return this.fecha_nac;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public int GetId_Sexo()
        {
            return this.id_sexo;
        }
        public async Task<int> Insertar_Cliente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/InsertarCliente.php?codigo="+codigo.ToString()+
                "&nombres="+nombres.ToString()+
                "&apellidos="+apellidos.ToString()+
                "&direccion="+direccion.ToString()+
                "&fecha_nacimiento="+fecha_nac.ToString()+
                "&telefono="+telefono.ToString()+
                "&id_sexo="+id_sexo.ToString();
            return await res.Insertar_Cliente(url);
        }
        public async Task<List<string>> Buscar_Cliente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/BuscarCliente.php?codigo=" + codigo.ToString();
            return await res.Buscar_Cliente(url);
        }
        public async Task<int> Edit_Cliente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/EditarCliente.php?codigo=" + codigo.ToString() +
                "&nombres=" + nombres.ToString() +
                "&apellidos=" + apellidos.ToString() +
                "&direccion=" + direccion.ToString() +
                "&fecha_nacimiento=" + fecha_nac.ToString() +
                "&telefono=" + telefono.ToString() +
                "&id_sexo=" + id_sexo.ToString();
            return await res.Edit_Cliente(url);
        }

    }
}
