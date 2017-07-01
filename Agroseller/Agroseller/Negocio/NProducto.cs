using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NProducto
    {
        private DProducto dProducto;

        public NProducto()
        {
            dProducto = new DProducto();
        }

        public async Task<List<string>> ListarConsumoAnimal()
        {
            return await dProducto.ListarConsumoAnimal();
        }
        public async Task<List<string>> ListarSuperFoods()
        {
            return await dProducto.ListarSuperFoods();
        }
    }
}
