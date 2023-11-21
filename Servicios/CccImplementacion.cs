using Cliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicios
{
    internal class CccImplementacion : CccInterfaz
    {


        public void darAltaCcc(List<CccDto> listaAntigua)
        {
            // creo un cliente
            CccDto ccc = crearNuevoCcc();
            // añado el cliente a listaAntigua
            listaAntigua.Add(ccc);


        }

        private CccDto crearNuevoCcc()
        {

            CccDto nuevoCliente = new CccDto();

            Console.WriteLine("introduzca una id: ");
            nuevoCliente.IdCcc = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("introduzca su isban: ");
            nuevoCliente.IsbanCuentaBancaria = Console.ReadLine();

            Console.WriteLine("introduzca su codigo Switch: ");
            nuevoCliente.CodigoSwitch = Console.ReadLine();

            Console.WriteLine("introduzca su dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCcc = Console.ReadLine();


            return nuevoCliente;

        }


    }
}
