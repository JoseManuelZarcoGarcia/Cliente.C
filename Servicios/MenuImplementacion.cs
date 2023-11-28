using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// metodo que impleneta el menu
        /// 211123 - jzg
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("###############################");
            Console.WriteLine("0, cerrar app");
            Console.WriteLine("1, dar de alta nuevo cliente");
            Console.WriteLine("2, dar de alta nueva cuenta corriente");
            Console.WriteLine("3, sacar dinero");
            Console.WriteLine("4, borrar cliente");
            Console.WriteLine("5, historial de operaciones");
            Console.WriteLine("###############################");
            Console.WriteLine("seleccione una opcion");

            /*readkey es para que imprima en opcionIntroducida el caracter seleccionado,
            y el true es para que no se muestre por pantalla*/
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            Console.WriteLine(opcionIntroducida);

            return opcionIntroducida;

        }


        public string pedirDni()
        {
            Console.WriteLine("escriba su dni: ");
            string dniCliente = Console.ReadLine();
            return dniCliente;
        }


    }
}
