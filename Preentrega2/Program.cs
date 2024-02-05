// See https://aka.ms/new-console-template for more information




internal class Program
{

    public static void Main(string[] args)


    {

        int opcion;

        Console.WriteLine("Menu Programa");
        Console.WriteLine("1.- Gestión 1");
        Console.WriteLine("2.- Gestión 2 ");
        Console.WriteLine("3.- Gestión 3 ");
        Console.WriteLine("4.- Gestión 4 ");


        Console.WriteLine("Por favor ingresar opcion: ");
        opcion = int.Parse(Console.ReadLine());

        Console.WriteLine("Se ingresó la opción: "+opcion);

        switch (opcion)
        {
            case 1:
                Console.WriteLine("opcion 1");
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




        }



    }

}







