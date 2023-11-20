using Cliente.Dtos;
using Cliente.Servicios;

namespace Cliente.Controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            List<ClienteDto> listaCliente = new List<ClienteDto>();


            MenuInterfaz mi = new MenuImplementacion();
            ClienteInterfaz ci = new ClienteImplementacion();

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
                        Console.WriteLine("[info] - se ejecuta el caso 2");
                        break;

                    case 3:
                        Console.WriteLine("[info] - se ejecuta el caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[info] - se ejecuta el caso 4");
                        break;

                    case 5:
                        Console.WriteLine("[info] - se ejecuta el caso 5");
                        break;

                    default:
                        Console.WriteLine("[info] - la opcion deseada no existe.");
                        break;
                }


            }

        }

    }
}