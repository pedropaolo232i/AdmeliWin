﻿using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProductoModel
    {
        public static Producto producto { get; set; }

        private WebService webService = new WebService();

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }
        public void cambiarClave()
        {

        }
       /* public async Task<dynamic> listarPorCategoria(string page, string items)
        {
            try
            {

                /*
                
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
    }
}