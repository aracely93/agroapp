﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Agroseller.Datos
{
    public class DAgente
    {


        int codigo;
        string nombres;
        string apellidos;
        int ci;
        string telefono;
        int id_sexo;

        public void SetCodigo(int cod)
        {
            this.codigo = cod;
        }
        public void SetNombre(string nom)
        {
            this.nombres = nom;
        }
        public void SetApellidos(string ap)
        {
            this.apellidos = ap;
        }
        public void SetCi(int ci)
        {
            this.ci = ci;
        }
        public void SetTelefono(string tel)
        {
            this.telefono = tel;
        }
        public void SetId_Sexo(int id)
        {
            this.id_sexo = id;
        }
        public int GetCodigo()
        {
            return this.codigo;
        }
        public string GetNombre()
        {
            return this.nombres;
        }
        public string GetApellido()
        {
            return this.apellidos;
        }
        public int GetCi()
        {
            return this.ci;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        public int GetId_Sexo()
        {
            return this.id_sexo;
        }
        public async Task<int> Insertar_Agente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/InsertarAgente.php?codigo=" + codigo.ToString() +
                "&nombres=" + nombres.ToString() +
                "&apellidos=" + apellidos.ToString() +
                "&ci=" + ci.ToString() +
                "&telefono=" + telefono.ToString() +
                "&id_sexo=" + id_sexo.ToString();
            return await res.Insertar_Agente(url);
        }
        public async Task<List<string>> Buscar_Agente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/BuscarAgente.php?codigo=" + codigo.ToString();
            return await res.Buscar_Agente(url);
        }
        public async Task<int> Edit_Agente()
        {
            RestClient res = new RestClient();
            string url = "http://tallerproyect.hol.es/Negocio/EditarAgente.php?codigo=" + codigo.ToString() +
                "&nombres=" + nombres.ToString() +
                "&apellidos=" + apellidos.ToString() +
                "&ci=" + ci.ToString() +
                "&telefono=" + telefono.ToString() +
                "&id_sexo=" + id_sexo.ToString();
            return await res.Edit_Agente(url);
        }

    }
}
