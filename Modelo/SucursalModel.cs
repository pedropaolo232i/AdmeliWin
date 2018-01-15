﻿using Entidad;
using Modelo.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class SucursalModel
    {
        private WebService webService = new WebService();

        public static Sucursal sucursal { get; set; }

        public void guardar()
        {

        }
        public void modificar()
        {

        }
        public void eliminar()
        {

        }

        public async Task<List<Sucursal>> listarSucursalesActivos()
        {
            try
            {
                // www.lineatienda.com/services.php/listarsucursalesactivos
                List<Sucursal> listSucursal = await webService.GETLis<Sucursal>("listarsucursalesactivos");
                return listSucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RootObject<Sucursal>> sucursales(int page, int items)
        {
            try
            {
                // www.lineatienda.com/services.php/sucursales/estado/1/100
                RootObject<Sucursal> sucursales = await webService.GETRoot<Sucursal>("sucursales", String.Format("estado/{0}/{1}", page, items));
                return sucursales;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task sucursalesPersonal(int idPersonal)
        {
            try
            {
                List<Sucursal> listSucursal = await webService.GETLis<Sucursal>("sucursalespersonal", idPersonal.ToString());
                SucursalModel.sucursal = listSucursal[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
