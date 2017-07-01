using Agroseller.Datos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
   public class NPedido
    {
        DPedido dPedido;

        public NPedido()
        {
            this.dPedido = new DPedido();
        }

        public async Task<int> Insertar_Pedido(int id,string fecha,float monto , int cod_agente,int cod_cliente)
        {
            dPedido.setid(id);
            dPedido.setfecha(fecha);
            dPedido.setmonto(monto);
            dPedido.setcod_agente(cod_agente);
            dPedido.setcod_cliente(cod_cliente);

            return await dPedido.Insertar_Pedidos();
        }
        public async Task<List<string>> Buscar_Pedido(int id)
        {
            dPedido.setid(id);
            return await dPedido.Buscar_Pedido();
        }
        public async Task<int> Edit_Pedido(int id, string fecha ,
            float monto, int cod_agente, int cod_cliente)
        {
            dPedido.setid(id);
            dPedido.setfecha(fecha);
            dPedido.setmonto(monto);
            dPedido.setcod_agente(cod_agente);
            dPedido.setcod_cliente(cod_cliente);
            return await dPedido.Edit_Pedido();
        }
    }
}
