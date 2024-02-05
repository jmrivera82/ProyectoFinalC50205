using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Preentrega2.modelo;

namespace Preentrega2.database
{
    public class GestorDeBaseDeDatos
    {
        private string stringConnection;

        public GestorDeBaseDeDatos()
        {
            this.stringConnection = "Server=localhost\\SQLEXPRESS;Database=proyecto;Trusted_Connection=True;";
        }

        //OBTENER USUARIOS

        public Usuarios ObtenerUsuarioPorId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))

            {
                string query = "Select * from usuarios where id = @id";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "id", Id);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int idObtenido = Convert.ToInt32(reader[name: "id"]);
                    string nombre = reader.GetString(i: 1);
                    string apellido = reader.GetString(i: 2);
                    string nombreUsuario = reader.GetString(i: 3);
                    string clave = reader.GetString(i: 4);
                    string mail = reader.GetString(i: 5);

                    Usuarios usuario = new Usuarios(Id, nombre, apellido, nombreUsuario, clave, mail);

                    return usuario;


                }

                throw new Exception(message: "Id no encontrado");
            }


        }

        // AGREGAR USUARIO

        public bool AgregarUsuario(Usuarios usuarios)
        {

            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "insert into usuarios (Nombre, Apellido, NombreUsuario, Contraseña, Mail) values (@nombre, @apellido, @nombreUsuario, @clave, @mail)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue(parameterName: "nombre", usuarios.Nombre);
                command.Parameters.AddWithValue(parameterName: "apellido", usuarios.Apellido);
                command.Parameters.AddWithValue(parameterName: "nombreUsuario", usuarios.NombreUsuario);
                command.Parameters.AddWithValue(parameterName: "clave", usuarios.Clave);
                command.Parameters.AddWithValue(parameterName: "mail", usuarios.Mail);

                connection.Open();

                return command.ExecuteNonQuery() > 0;


            }


        }

        //BORRAR USUARIO

        public bool BorrarUsuarioPorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "delete from usuarios where id = @id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "id", id);
                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }

        //ACTUALIZAR USUARIO

        public bool ActualizarUsuarioPorId(int id, Usuarios usuarios)
        {
            using (SqlConnection connection = new SqlConnection(this.stringConnection))
            {

                string query = "update usuarios set nombre=@nombre, apellido = @apellido, nombreUsuario = @nombreUsuario, contraseña=@clave, mail = @mail where id=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName: "id", id);
                command.Parameters.AddWithValue(parameterName: "nombre", usuarios.Nombre);
                command.Parameters.AddWithValue(parameterName: "apellido", usuarios.Apellido);
                command.Parameters.AddWithValue(parameterName: "nombreUsuario", usuarios.NombreUsuario);
                command.Parameters.AddWithValue(parameterName: "clave", usuarios.Clave);
                command.Parameters.AddWithValue(parameterName: "mail", usuarios.Mail);
                connection.Open();
                return command.ExecuteNonQuery() > 0;


            }
        }
    }
}
