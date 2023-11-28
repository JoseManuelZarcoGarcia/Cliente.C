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
        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniBuscar = mi.pedirDni();
            //  Borrado por objeto especifico

            ClienteDto clienteABorrar = new ClienteDto();
            foreach(ClienteDto cliente in listaAntigua)
            {

                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    /* este no lo podemos hacer ya que no da la referencia de memoria, solo los valores de los campos
                    clienteABorrar.IdCliente = cliente.IdCliente;
                    clienteABorrar.NombreCliente = cliente.NombreCliente;
                    clienteABorrar.ApellidosCliente = cliente.ApellidosCliente;
                    clienteABorrar.DniCliente = cliente.DniCliente; 
                    clienteABorrar.FchNacimientoCliente = cliente.FchNacimientoCliente;
                    clienteABorrar.FchAltaCliente = cliente.FchAltaCliente;
                    clienteABorrar.FchBajaCliente = cliente.FchBajaCliente;
                    clienteABorrar.TlfCliente = cliente.TlfCliente;
                    clienteABorrar.EmailCliente = cliente.EmailCliente;
                    */
                    break;
                }

            }
            listaAntigua.Remove(clienteABorrar);



            //  Borrado por posicion

            /* Posicion
            int i;
            bool aBorrar = false;
            for (i = 0; i < listaAntigua.Count(); i++)
            {

                if (listaAntigua[i].DniCliente.Equals(dniBuscar))
                {
                    aBorrar = true;
                    break;
                }           
            }
                // par borrar en la posicion que es el dni, por eso iniciamos i antes del for
            if (aBorrar)
            {
                listaAntigua.RemoveAt(i);
            }

            else
            {
                Console.WriteLine("el cliente no existe");
            }
            */
        }

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
