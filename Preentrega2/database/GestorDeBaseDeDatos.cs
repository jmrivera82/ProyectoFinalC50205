using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Preentrega2.database
{
    public class GestorDeBaseDeDatos
    {
        private string stringConnection;

        public GestorDeBaseDeDatos()
        {
            this.stringConnection = "Server=localhost\\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";
        }
    }
}
