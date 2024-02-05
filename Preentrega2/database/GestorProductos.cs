using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Preentrega2.modelo;

namespace Preentrega2.database
{
    public class GestorProductos
    {
        private string stringConnection;

        public GestorProductos()
        {
            this.stringConnection = "Server=localhost\\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";
        }

        //OBTENER PRODUCTOS

        public Productos ObtenerProductosPorId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))

            {
                string query = "Select * from productos where id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader[name: "id"]);
                    string descripcion = reader.GetString(i: 1);
                    double costo = reader.GetDouble(i: 2);
                    double precioVenta = reader.GetDouble(i: 3);
                    int stock = Convert.ToInt32(reader[name: "stock"]);
                    int idUsuario = Convert.ToInt32(reader[name: "idUsuario"]);
                      
                    Productos productos = new Productos(Id, descripcion, costo, precioVenta, stock, idUsuario);

                    return productos;

                }

                throw new Exception(message: "Id no encontrado");
            }

        }

        // AGREGAR PRODUCTOS

        public bool AgregarProductos(Productos productos)
        {

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "insert into productos (descripcion, costo, precioventa, stock, idusuario) values (@descripcion, @costo, @precioventa, @stock, @idusuario)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "Descripcion", productos.Descripcion);
                command.Parameters.AddWithValue(parameterName: "Costo", productos.Costo);
                command.Parameters.AddWithValue(parameterName: "PrecioVenta", productos.PrecioVenta);
                command.Parameters.AddWithValue(parameterName: "Stock", productos.Stock);
                command.Parameters.AddWithValue(parameterName: "IdUsuario", productos.IdUsuario);

                connection.Open();

                return command.ExecuteNonQuery() > 0;


            }


        }

        //BORRAR PRODUCTO

        public bool BorrarProductoPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "delete from productos where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

        //ACTUALIZAR PRODUCTO

        public bool ActualizarProductos(int id, Productos productos)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "update productos set descripcion=@descripcion, costo = @costo, precioventa = @precioventa, stock=@stock, idusuario = @idusuario where id=@id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", id);
                command.Parameters.AddWithValue(parameterName: "Descripcion", productos.Descripcion);
                command.Parameters.AddWithValue(parameterName: "Costo", productos.Costo);
                command.Parameters.AddWithValue(parameterName: "PrecioVenta", productos.PrecioVenta);
                command.Parameters.AddWithValue(parameterName: "Stock", productos.Stock);
                command.Parameters.AddWithValue(parameterName: "IdUsuario", productos.IdUsuario);

                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }



    }
}
