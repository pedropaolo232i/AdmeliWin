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


        public async Task<Response> guardar(Sucursal param)
        {
            try
            {
                // localhost/admeli/xcore2/xcore/services.php/sucursal/guardar
                return await webService.POSTSend("sucursal", "guardar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<Response> modificar(Sucursal param)
        {
            try
            {
                // localhost/admeli/xcore2/xcore/services.php/sucursal/modificar
                return await webService.POSTSend("sucursal", "modificar", param);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public async Task<List<Sucursal>> sucursalesProducto()
        {
            try
            {
                // www.lineatienda.com/services.php/sucursales/id/nombre/estado/1
                List<Sucursal> listSucursal = await webService.GETLis<Sucursal>("sucursales", "id/nombre/estado/1");
                return listSucursal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
