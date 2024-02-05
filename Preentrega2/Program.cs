// See https://aka.ms/new-console-template for more information




using Preentrega2.database;
using Preentrega2.modelo;
using System;

internal class Program
{

    public static void Main(string[] args)


    {

        int opcion, opcionusuarios;

        Console.WriteLine("Menu Programa");
        Console.WriteLine("1.- Gestión de usuarios");
        Console.WriteLine("2.- Gestión 2 ");
        Console.WriteLine("3.- Gestión 3 ");
        Console.WriteLine("4.- Gestión 4 ");

  
        Console.WriteLine("Por favor ingresar opcion: ");
        opcion = int.Parse(Console.ReadLine());


        Console.WriteLine("Se ingresó la opción: "+opcion);

        switch (opcion)
        {
            case 1:

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Gestión de usuarios");
                Console.WriteLine("1.- Obtener usuario");
                Console.WriteLine("2.- Crear usuario");
                Console.WriteLine("3.- Borrar usuario");
                Console.WriteLine("4.- Actualizar usuario");


                Console.WriteLine("Por favor ingresar opcion: ");
                opcionusuarios = int.Parse(Console.ReadLine());

                switch (opcionusuarios)
                {
                    case 1:
                        Console.WriteLine("OBTENIENDO DATOS DE USUARIO....");
                        
                        GestorDeBaseDeDatos db = new GestorDeBaseDeDatos();


                        try
                        {

                            Usuarios usuarioObtenido = db.ObtenerUsuarioPorId(Id: 1);
                            Console.WriteLine(usuarioObtenido.ToString());

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 2:

                        Console.WriteLine("CREANDO USUARIO....");

                        GestorDeBaseDeDatos db1 = new GestorDeBaseDeDatos();


                        try
                        {

                        Usuarios usuarioNuevo = new Usuarios(nombre: "Juanin", apellido: "Juan Harry", nombreUsuario: "juanin", clave: "310", mail: "juan@mail.com");

                        if (db1.AgregarUsuario(usuarioNuevo))
                        {
                            Console.WriteLine(value: "Usuario fue agregado");
                        }

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        Console.WriteLine("BORRANDO USUARIO....");

                        GestorDeBaseDeDatos db2 = new GestorDeBaseDeDatos();

                        try
                        {
                            if (db2.BorrarUsuarioPorId(id: 5))
                            {
                                Console.WriteLine(value: "Usuario fue eliminado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 4:

                        Console.WriteLine("ACTUALIZANDO USUARIO....");

                        GestorDeBaseDeDatos db3 = new GestorDeBaseDeDatos();

                        try
                        {
                            Usuarios usuarioAActualizar = new Usuarios(nombre: "Mario", apellido: "Hugo", nombreUsuario: "mhugo", clave: "1111", mail: "mhugo@mail.com");

                            if (db3.ActualizarUsuarioPorId(id: 4, usuarioAActualizar))
                            {
                                Console.WriteLine(value: "Usuario fue actualizado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                }




            break;

            case 2:
                Console.WriteLine("opcion 2");
                break;

            case 3:
                Console.WriteLine("opcion 3");
                break;

            case 4:
                Console.WriteLine("opcion 4");
                break;

            default:
                Console.WriteLine("Debe ingresar una opción válida");
                break;



        }



    }

}







