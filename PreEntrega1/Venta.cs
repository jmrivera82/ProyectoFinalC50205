﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreEntrega1
{
    public class Venta
    {
        public int Id { get; set; }

        public int IdProducto { get; set; }
        
        public double Stock { get; set; }   
        
        public int IdVenta { get; set; }    
    }
}
