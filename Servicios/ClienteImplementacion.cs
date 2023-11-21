using Cliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {

        /// <summary>
        /// metodo que da de alta a un nuevo cliente que se crea dentro y la añade a la lista
        /// 211123 - jzg
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente(List<ClienteDto> listaAntigua)
        {
            // creo un cliente
            ClienteDto cliente = crearNuevoCliente();
            // añado el cliente a listaAntigua
            listaAntigua.Add(cliente);


        }

        /// <summary>
        /// metodo que crea un nuevo cliente
        /// 211123 - jzg
        /// </summary>
        /// <returns></returns>
        private ClienteDto crearNuevoCliente()
        {
            
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("introduzca una id: ");
            nuevoCliente.IdCliente = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("introduzca su nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("introduzca su apellid: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("introduzca su dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("introduzca su fecha de nacimiento: ");
            nuevoCliente.FchNacimientoCliente = Console.ReadLine();

            Console.WriteLine("introduzca su email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("introduzca su telefono: ");
            nuevoCliente.TlfCliente = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();


            return nuevoCliente;

        }

    }
}
