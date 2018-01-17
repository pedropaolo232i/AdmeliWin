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
        public async Task<dynamic> listarPorCategoria(string page, string items, Dictionary<string, int> dictionary)
        {
            try
            {
                // www.lineatienda.com/services.php/productos/categoria/1/100
                // string json = 
                RootObject<Producto> productos = await webService.POSTRoot<Producto>("productos", String.Format("categoria/{0}/{1}",page,items), "");
                return productos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
