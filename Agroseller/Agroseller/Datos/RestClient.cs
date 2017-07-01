using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft;
using System.IO;

using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;


namespace Agroseller.Datos
{
    public class RestClient
    {
        
        public async Task<string> Get_Login(string url)
        {
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response=await request.GetResponseAsync())
            {
                using(Stream stream = response.GetResponseStream())
                {
                    
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        return resultStream;
                    }
                    
                }
            }
        }

        public async Task<List<string>> Get_Familia(string url)
        {
            List<string> lista = new List<string>();
            
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DFamily>>(resultStream);
                        
                        foreach(var question in obj)
                        {
                            lista.Add(question.Descripcion);
                            lista.Add(question.Url_image);
                        }
                        return lista;
                    }
                    

                }

            }
        }

        public async Task<List<string>> Buscar_Pedido(string url)
        {
            List<string> lista = new List<string>();
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DPedido>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.fecha);
                            lista.Add(question.monto.ToString());
                            lista.Add(question.cod_agente.ToString());
                            lista.Add(question.cod_cliente.ToString());


                        }
                    }


                }

            }
            return lista;
        }

        public async Task<int> Insertar_Pedidos(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }

        public async Task<int> Edit_Pedido(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;

        }

        public async Task<List<string>> Get_Producto(string url)
        {
            List<string> lista = new List<string>();

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DProducto>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.Nombre);
                            lista.Add(question.Url_image);
                        }
                        return lista;
                    }


                }

            }
        }



        public async Task<List<string>> Listar_Sexo(string url)
        {
            List<string> lista = new List<string>();

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DSexo>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.descripcion);
                        }
                        return lista;
                    }


                }

            }
        }

        public async Task<int> Insertar_Cliente(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }


        public async Task<List<string>> Buscar_Cliente(string url)
        {
            List<string> lista = new List<string>();
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DCliente>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.nombres);
                            lista.Add(question.apellidos);
                            lista.Add(question.direccion);
                            lista.Add(question.fecha_nacimiento);
                            lista.Add(question.telefono);
                            lista.Add(question.id_sexo.ToString());

                        }
                    }


                }

            }
            return lista;
        }


        public async Task<int> Edit_Cliente(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }



        public async Task<int> Insertar_Administrador(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }


        public async Task<List<string>> Buscar_Administrador(string url)
        {
            List<string> lista = new List<string>();
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DAdministrador>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.nombres);
                            lista.Add(question.apellidos);
                            lista.Add(question.ci);
                            lista.Add(question.telefono);
                            lista.Add(question.id_sexo.ToString());

                        }
                    }


                }

            }
            return lista;
        }


        public async Task<int> Edit_Administrador(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }




        public async Task<int> Insertar_Agente(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }


        public async Task<List<string>> Buscar_Agente(string url)
        {
            List<string> lista = new List<string>();
            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.DAdministrador>>(resultStream);

                        foreach (var question in obj)
                        {
                            lista.Add(question.nombres);
                            lista.Add(question.apellidos);
                            lista.Add(question.ci);
                            lista.Add(question.telefono);
                            lista.Add(question.id_sexo.ToString());

                        }
                    }


                }

            }
            return lista;
        }


        public async Task<int> Edit_Agente(string url)
        {
            int i = -1;

            System.Net.WebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            using (System.Net.WebResponse response = await request.GetResponseAsync())
            {
                using (Stream stream = response.GetResponseStream())
                {

                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string resultStream = reader.ReadToEnd();
                        var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InfoList.Insert>>(resultStream);
                        string resssss = "";
                        foreach (var question in obj)
                        {
                            resssss = question.message;
                        }
                        if (String.Equals(resssss, "OK", StringComparison.Ordinal))
                        {
                            i = 1;
                        }
                    }


                }

            }
            return i;
        }
    }

  

}
