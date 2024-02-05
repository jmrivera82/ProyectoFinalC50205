using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Preentrega2.modelo
{
    public class Usuarios
    {

        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string clave;
        private string mail;

        public Usuarios() { }

        public Usuarios(string nombre, string apellido, string nombreUsuario, string clave, string mail)
        {
            //this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.clave = clave;
            this.mail = mail;
        }

        public Usuarios(int id, string nombre, string apellido, string nombreUsuario, string clave, string mail) : this(nombre, apellido, nombreUsuario, clave, mail)
        {
            this.id = id;
        }


        public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }

        public string Apellido { get => this.apellido; set => this.apellido = value; }

        public string NombreUsuario { get => this.nombreUsuario; set => this.nombreUsuario = value; }

        public string Clave { get => this.clave; set => this.clave = value; }

        public string Mail { get => this.mail; set => this.mail = value; }





        public override string ToString()
        {
            return $"nombre: {this.nombre}, apellido: {this.apellido}";

        }


    }
}
