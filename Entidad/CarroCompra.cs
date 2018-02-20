﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class CarroCompra
    {
        public int idDetalleCompra { get; set; }
        public double cantidad { get; set; }
        public double cantidadUnitaria { get; set; }
        public string codigoProducto { get; set; }
        public string descripcion { get; set; }
        public double descuento { get; set; }
        public int estado { get; set; }
        public int idCombinacionAlternativa { get; set; }
        public int idCompra { get; set; }
        public int idPresentacion { get; set; }
        public int idProducto { get; set; }
        public int idSucursal { get; set; }
        public string nombreCombinacion { get; set; }
        public string nombreMarca { get; set; }
        public string nombrePresentacion { get; set; }
        public int nro { get; set; }
        public int precioUnitario { get; set; }
        public double total { get; set; }
    }
}
