﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("###############################");
            Console.WriteLine("0, cerrar app");
            Console.WriteLine("1, darse de alta");
            Console.WriteLine("2, ingresar dinero");
            Console.WriteLine("3, sacar dinero");
            Console.WriteLine("4, tranferir dinero");
            Console.WriteLine("5, historial de operaciones");
            Console.WriteLine("###############################");
            Console.WriteLine("seleccione una opcion");

            /*readkey es para que imprima en opcionIntroducida el caracter seleccionado,
            y el true es para que no se muestre por pantalla*/
            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');
            Console.WriteLine(opcionIntroducida);

            return opcionIntroducida;

        }


    }
}
