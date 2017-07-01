using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Agroseller
{
    public class InfoList
    {
        public class Bienvenido
        {
            public string Foto2 { get; set; }
        }

        public class ListaFamilia {
            public string Foto2 { get; set; }
            public string Descripcion2 { get; set; }
        }

        public class DFamily
        {
            public string Descripcion { get; set; }
            public string Url_image { get; set; }

        }
        public class ListaProducto
        {
            public string Foto2 { get; set; }
            public string Descripcion2 { get; set; }
        }
        public class DProducto
        {
            public string Nombre { get; set; }
            public string Url_image { get; set; }

        }

        public class DPedido
        {
            public string fecha { get; set; }
            public float monto{ get; set; }
            public int cod_agente { get; set; }
            public int cod_cliente { get; set; } 

        }
        public class DSexo{
            public string descripcion { get; set; }
        }

        public class Insert{
            public string message { get; set; }
        }
        public class DCliente
        {
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string direccion { get; set; }
            public string fecha_nacimiento { get; set; }
            public string telefono { get; set; }
            public int id_sexo { get; set; }
        }
        public class DAdministrador
        {
            public string nombres { get; set; }
            public string apellidos { get; set; }
            public string ci { get; set; }
            public string telefono { get; set; }
            public int id_sexo { get; set; }
        }


        public class BotMessage
        {
            public string Id { get; set; }
            public string ConversationId { get; set; }
            public DateTime Created { get; set; }
            public string From { get; set; }
            public string Text { get; set; }
            public string ChannelData { get; set; }
            public string[] Images { get; set; }
            public Attachment[] Attachments { get; set; }
            public string ETag { get; set; }
        }
        public class Attachment
        {
            public string Url { get; set; }
            public string ContentType { get; set; }
        }
        public class BotMessageRoot
        {
            public List<BotMessage> Messages { get; set; }
        }
        public class Conversation
        {
            public string ConversationId { get; set; }
            public string Token { get; set; }
            public string ETag { get; set; }
        }

    }
}
