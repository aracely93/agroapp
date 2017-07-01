using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    class DPedido
    {

        private int id;
        private string fecha;
        private float monto;
        private int cod_agente;
        private int cod_cliente;

        public DPedido()
        {
        }

        public void setid(int id)
        {
            this.id = id;
        }

        public void setfecha(string fecha)
        {
            this.fecha = fecha;
        }
        public void setmonto(float monto)
        {
            this.monto = monto;
        }
        public void setcod_agente(int cod_agente)
        {
            this.cod_agente = cod_agente;
        }

        public void setcod_cliente(int cod_cliente)
        {
            this.cod_cliente = cod_cliente;
        }

        public int getid()
        {
            return this.id;
        }

        public string
            getfecha()
        {
            return this.fecha;
        }


        public float getmonto()
        {
            return this.monto;
        }

        public int getcod_agente()
        {
            return this.cod_agente;
        }

        public int getcod_cliente()
        {
            return this.cod_cliente;
        }


        public async Task<int> Insertar_Pedidos()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/InsertarCliente.php?id=" + id.ToString() +
                "&fecha=" + fecha.ToString()+
                "&monto=" + monto.ToString() +
                "&cod_agente=" + cod_agente.ToString() +
                "&cod_cliente=" + cod_cliente.ToString();
            return await res.Insertar_Pedidos(url);
        }
        public async Task<List<string>> Buscar_Pedido()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/BuscarCliente.php?id=" + id.ToString();
            return await res.Buscar_Pedido(url);
        }
        public async Task<int> Edit_Pedido()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/EditarCliente.php?id=" + id.ToString() +
            "&fecha=" + fecha+
                "&monto=" + monto.ToString() +
                "&cod_agente=" + cod_agente.ToString() +
                "&cod_cliente=" + cod_cliente.ToString();
            return await res.Edit_Pedido(url);
        }

    }
}
