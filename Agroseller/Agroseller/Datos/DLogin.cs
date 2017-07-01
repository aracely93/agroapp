using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    
    public class DLogin
    {
        private string user;
        private string password;
        private int privilegio;
        private ConexionSingleton conexion;

        public DLogin()
        {
            conexion = new ConexionSingleton();
        }
        public void SetUser(string user)
        {
            this.user = user;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public void SetPrivilegio(int privilegio)
        {
            this.privilegio = privilegio;
        }
        public string GetUser()
        {
            return this.user;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public int GetPrivilegio()
        {
            return this.privilegio;
        }


        public string User { set; get; }


        public async Task<string> BuscarLogin()
        {
                RestClient client = new RestClient();
                string url = "http://tallerproyect.hol.es/VerificarLogin.php?user=" + user.ToString() + "&password=" + password.ToString() + "&privilegio=" + privilegio.ToString();
                return await client.Get_Login(url);
            
        }

    }
    
}
