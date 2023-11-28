using Cliente.Dtos;
using Cliente.Servicios;

namespace Cliente.Controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            List<ClienteDto> listaCliente = new List<ClienteDto>();
            List<CccDto> listaCcc = new List<CccDto>();

            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();
            CccInterfaz ccci = new CccImplementacion();

            bool cerrarMenu = false;
            int opcionSeleccionada;

            
            while (!cerrarMenu)
            {
                opcionSeleccionada = mi.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);
                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[info] - Cerrar ");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[info] - Alta nuevo cliente");
                        ci.darAltaCliente(listaCliente);
                        /*  Pruebas
                        foreach(ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        */
                        break;

                    case 2:
                        Console.WriteLine("[info] - Crear nueva ccc");
                        ccci.darAltaCcc(listaCcc);
                        break;

                    case 3:
                        Console.WriteLine("[info] - se ejecuta el caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[info] - Eliminar un cliente");
                        ci.borrarCliente(listaCliente);
                        break;

                    case 5:
                        Console.WriteLine("[info] - Ver clienet");
                        foreach (ClienteDto cliente in listaCliente)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;

                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }


            }

        }

    }
}