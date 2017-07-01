using System;
using System.Collections.Generic;
using System.Text;

namespace Agroseller.Datos
{
    public class ConexionSingleton
    {
        private static ConexionSingleton INSTANCE = null;
        public int state = 0;

        public ConexionSingleton()
        {
            state=Conectar();
        }
        public ConexionSingleton GetInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ConexionSingleton();
            }
            return INSTANCE;
        }
        public int Conectar()
        {
            RestClient client = new RestClient();
            //var main = client.Get("http://tallerproyect.hol.es/Conexion.php");
            return 1;
        }

    }
}
