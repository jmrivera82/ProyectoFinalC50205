﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega2.modelo
{
    public class ProductoVendido
    {

        private int id;
        private int idProducto;
        private int stock;
        private int idVenta;

        public ProductoVendido() { }

        public ProductoVendido(int idProducto, int stock, int idVenta)
        {
            //this.id = id;
            this.IdProducto = idProducto;
            this.Stock = stock;
            this.IdVenta = idVenta;
        }

        public ProductoVendido(int id, int idProducto, int stock, int idVenta) : this(idProducto, stock, idVenta)
        {
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdVenta { get => idVenta; set => idVenta = value; }

        public override string ToString()
        {
            return $"IdProducto: {this.IdProducto}, IdVenta: {this.IdVenta}";

        }



    }
}
