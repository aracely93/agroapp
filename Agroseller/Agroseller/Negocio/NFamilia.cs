using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NFamilia
    {
        DFamilia dFamilia;
        
        public NFamilia()
        {
            dFamilia = new DFamilia();
        }

        public async Task<List<string>> ListarFamilia()
        {
            return await dFamilia.ListarFamilia();
        }
    }
}
