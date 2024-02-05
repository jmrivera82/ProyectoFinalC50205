using Preentrega2.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega2.database
{
    public class GestorVentas
    {

        private string stringConnection;

        public GestorVentas()
        {
            this.stringConnection = "Server=localhost\\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";
        }

        //OBTENER VENTA

        public Venta ObtenerVentas(int Id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))

            {
                string query = "Select * from ventas where id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader[name: "id"]);
                    string comentarios = reader.GetString(i: 1);
                    int idUsuario = Convert.ToInt32(reader[name: "idUsuario"]);

                    Venta ventas = new Venta(comentarios, idUsuario);

                    return ventas;

                }

                throw new Exception(message: "Id no encontrado");
            }

        }

        // AGREGAR VENTAS

        public bool AgregarVentas(Venta ventas)
        {

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "insert into ventas (comentarios, idusuario) values (@comentarios, @venta)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "Comentarios", ventas.Comentarios);
                command.Parameters.AddWithValue(parameterName: "IdUsuario", ventas.IdUsuario);

                connection.Open();

                return command.ExecuteNonQuery() > 0;


            }


        }

        //BORRAR VENTA

        public bool BorrarVentaPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "delete from ventas where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

        //ACTUALIZAR VENTAS

        public bool ActualizarVentas(int id, Venta ventas)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "update ventas set comentarios=@comentarios, idusuario = @idusuario where id=@id";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", id);
                command.Parameters.AddWithValue(parameterName: "comentarios", ventas.Comentarios);
                command.Parameters.AddWithValue(parameterName: "IdUsuario", ventas.IdUsuario);

                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

    }
}
