using System;
using System.Collections.Generic;
using System.Text;
using Agroseller.Datos;
using System.Threading.Tasks;

namespace Agroseller.Negocio
{
    public class NLogin
    {
        DLogin dLogin;

        public NLogin()
        {
            dLogin = new DLogin();
        }
        public async Task<string> BuscarLogin(string user, string password, int privilegio)
        {
            dLogin.SetUser(user);
            dLogin.SetPassword(password);
            dLogin.SetPrivilegio(privilegio);
            return await dLogin.BuscarLogin();
        }

    }
}
