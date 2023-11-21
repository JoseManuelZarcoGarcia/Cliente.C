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

        /// <summary>
        /// metodo que da de alta la nueva cuenta que se crea dentro y la añade a la lista
        /// 211123 - jzg
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCcc(List<CccDto> listaAntigua)
        {
            // creo una cuenta bancaria
            CccDto ccc = crearNuevoCcc();
            // añado la cuenta a listaAntigua
            listaAntigua.Add(ccc);


        }

        /// <summary>
        /// metodo que crea una nueva cuenta bancaria
        /// 211123 - jzg
        /// </summary>
        /// <returns></returns>
        private CccDto crearNuevoCcc()
        {

            CccDto nuevoCliente = new CccDto();

            Console.WriteLine("introduzca una id: ");
            nuevoCliente.IdCcc = (Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("introduzca su isban: ");
            nuevoCliente.IsbanCuentaBancaria = Console.ReadLine();

            Console.WriteLine("introduzca su dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

            Console.WriteLine("introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCcc = Console.ReadLine();


            return nuevoCliente;

        }


    }
}
