using Preentrega2.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega2.database
{
    public class GestorDeProductosVendidos
    {

        private string stringConnection;

        public GestorDeProductosVendidos()
        {
            this.stringConnection = "Server=localhost\\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";
        }

        //OBTENER PRODUCTOS VENDIDOS POR ID

        public ProductoVendido ObtenerProductosVendidosPorId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))

            {
                string query = "Select * from productosvendidos where id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader[name: "id"]);
                    int idProducto = Convert.ToInt32(reader[name: "idProducto"]);
                    int stock = Convert.ToInt32(reader[name: "stock"]);
                    int idVenta = Convert.ToInt32(reader[name: "idVenta"]);


                    ProductoVendido productoVendido = new ProductoVendido(Id, idProducto, stock, idVenta);

                    return productoVendido;

                }

                throw new Exception(message: "Id no encontrado");
            }

        }

        // AGREGAR PRODUCTO VENDIDO

        public bool AgregarProductoVendido(ProductoVendido productoVendido)
        {

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "insert into productosvendidos (idproducto, stock, idventa) values (@idproducto, @stock, @idventa)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "IdProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue(parameterName: "Stock", productoVendido.Stock);
                command.Parameters.AddWithValue(parameterName: "IdVenta", productoVendido.IdVenta);
           
                connection.Open();

                return command.ExecuteNonQuery() > 0;


            }


        }

        //BORRAR PRODUCTO VENDIDO

        public bool BorrarProductoVendido(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "delete from productosvendidos where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

        //ACTUALIZAR PRODUCTO VENDIDO

        public bool ActualizarProductoVendido(int id, ProductoVendido productoVendido)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "update productosvendidos set idproducto=@idproducto, stock = @stock, idventa = @idventa where id=@id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "IdProducto", productoVendido.IdProducto);
                command.Parameters.AddWithValue(parameterName: "Stock", productoVendido.Stock);
                command.Parameters.AddWithValue(parameterName: "IdVenta", productoVendido.IdVenta);

                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }




    }
}
