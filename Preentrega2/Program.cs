// See https://aka.ms/new-console-template for more information




using Preentrega2.database;
using Preentrega2.modelo;
using System;

internal class Program
{

    public static void Main(string[] args)


    {

        int opcion, opcionusuarios, opcionproductos;

        int opcionventa=0;

        Console.WriteLine("Menu Programa");
        Console.WriteLine("1.- Gestión de usuarios");
        Console.WriteLine("2.- Gestión de productos ");
        Console.WriteLine("3.- Gestión de productos vendidos");
        Console.WriteLine("4.- Gestión de ventas ");

  
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

            //CASO 2 PRODUCTOS

            case 2:

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Gestión de productos");
                Console.WriteLine("1.- Obtener producto");
                Console.WriteLine("2.- Crear producto");
                Console.WriteLine("3.- Borrar producto");
                Console.WriteLine("4.- Actualizar producto");


                Console.WriteLine("Por favor ingresar opcion: ");
                opcionproductos = int.Parse(Console.ReadLine());


                switch (opcionproductos)
                {
                    case 1:
                        Console.WriteLine("OBTENIENDO DATOS DE PRODUCTO....");

                        GestorProductos db = new GestorProductos();


                        try
                        {

                            Productos productoObtenido = db.ObtenerProductosPorId(Id: 2);
                            Console.WriteLine(productoObtenido.ToString());

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 2:

                        Console.WriteLine("CREANDO PRODUCTO....");

                        GestorProductos db1 = new GestorProductos();


                        try
                        {

                            Productos productoNuevo = new Productos(descripcion: "Tallarines", costo: 890, precioVenta: 1190, stock: 1000, idUsuario: 1);

                            if (db1.AgregarProductos(productoNuevo))
                            {
                                Console.WriteLine(value: "Producto fue agregado");
                            }

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        Console.WriteLine("BORRANDO PRODUCTO....");

                        GestorProductos db2 = new GestorProductos();

                        try
                        {
                            if (db2.BorrarProductoPorId(id: 1))
                            {
                                Console.WriteLine(value: "Producto fue eliminado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 4:

                        Console.WriteLine("ACTUALIZANDO PRODUCTO....");

                        GestorProductos db3 = new GestorProductos();

                        try
                        {
                            Productos productoAActualizar = new Productos(descripcion: "Arroz", costo: 690, precioVenta: 1390, stock: 500, idUsuario: 1);

                            if (db3.ActualizarProductos(id: 1, productoAActualizar))
                            {
                                Console.WriteLine(value: "Producto fue actualizado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                }




                break;


            //CASO 3 PRODUCTOS VENDIDOS

            case 3:

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Gestión de productos vendidos");
                Console.WriteLine("1.- Obtener producto vendido");
                Console.WriteLine("2.- Crear producto vendido");
                Console.WriteLine("3.- Borrar producto vendido");
                Console.WriteLine("4.- Actualizar producto vendido");


                Console.WriteLine("Por favor ingresar opcion: ");
                opcion = int.Parse(Console.ReadLine());

        
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("OBTENIENDO DATOS DE PRODUCTO VENDIDO....");

                        GestorDeProductosVendidos db = new GestorDeProductosVendidos();


                        try
                        {

                            ProductoVendido productoVendidoObtenido = db.ObtenerProductosVendidosPorId(Id: 2);
                            Console.WriteLine(productoVendidoObtenido.ToString());

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 2:

                        Console.WriteLine("CREANDO PRODUCTO VENIDIDO....");

                        GestorDeProductosVendidos db1 = new GestorDeProductosVendidos();


                        try
                        {

                            ProductoVendido productoVendidoNuevo = new ProductoVendido(idProducto: 2, stock: 12, idVenta: 1);

                            if (db1.AgregarProductoVendido(productoVendidoNuevo))
                            {
                                Console.WriteLine(value: "Producto fue agregado");
                            }

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        Console.WriteLine("BORRANDO PRODUCTO VENDIDO....");

                        GestorDeProductosVendidos db2 = new GestorDeProductosVendidos();

                        try
                        {
                            if (db2.BorrarProductoVendido(id: 2))
                            {
                                Console.WriteLine(value: "Producto vendido fue eliminado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 4:

                        Console.WriteLine("ACTUALIZANDO PRODUCTO VENDIDO....");

                        GestorDeProductosVendidos db3 = new GestorDeProductosVendidos();

                        try
                        {
                            ProductoVendido productovendidoAActualizar = new ProductoVendido(idProducto: 2, stock: 40, idVenta: 2);

                            if (db3.ActualizarProductoVendido(id: 1, productovendidoAActualizar))
                            {
                                Console.WriteLine(value: "Producto fue actualizado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                }




                break;

            case 4:
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Gestión de Ventas");
                Console.WriteLine("1.- Obtener venta");
                Console.WriteLine("2.- Crear venta");
                Console.WriteLine("3.- Borrar venta");
                Console.WriteLine("4.- Actualizar venta");


                Console.WriteLine("Por favor ingresar opcion: ");
                opcion = int.Parse(Console.ReadLine());


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("OBTENIENDO DATOS DE VENTA...");

                        GestorVentas db = new GestorVentas();


                        try
                        {

                            Venta ventaObtenida = db.ObtenerVentas(Id: 1);

                            Console.WriteLine(ventaObtenida.ToString());

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 2:

                        Console.WriteLine("CREANDO VENTA NUEVA....");

                        GestorVentas db1 = new GestorVentas();


                        try
                        {

                            Venta ventaNueva = new Venta(comentarios: "camion de bebidas",  idUsuario: 1);

                            if (db1.AgregarVentas(ventaNueva))
                            {
                                Console.WriteLine(value: "Venta fue agregado");
                            }

                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3:

                        Console.WriteLine("BORRANDO VENTA....");

                        GestorVentas db2 = new GestorVentas();

                        try
                        {
                            if (db2.BorrarVentaPorId(id: 2))
                            {
                                Console.WriteLine(value: "Producto vendido fue eliminado");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    case 4:

                        Console.WriteLine("ACTUALIZANDO VENTA....");

                        GestorVentas db3 = new GestorVentas();

                        try
                        {
                            Venta ventaAActualizar = new Venta(comentarios: "detergentes", idUsuario: 1);

                            if (db3.ActualizarVentas(id: 1, ventaAActualizar))
                            {
                                Console.WriteLine(value: "La Venta fue actualizada");
                            }
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                }




                break;

            default:
                Console.WriteLine("Debe ingresar una opción válida");
                break;



        }



    }

}







