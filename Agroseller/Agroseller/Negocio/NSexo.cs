using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NSexo
    {
        DSexo dSexo;
        public NSexo()
        {
            dSexo = new DSexo();
        }
        public async Task<List<string>> Listar_Sexo()
        {
            return await dSexo.Listar_Sexo();
        }
    }
}
