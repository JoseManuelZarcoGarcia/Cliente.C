using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Dtos
{
    internal class CccDto
    {
        /*
         
        funcionalidad de dar de alta una nueva centa bancaria
        dentro de cuenta bancaria tiene que haber un dato que indique que el cliente y la cuenta corriente estan enlazadas
         
        campos:
        idCuentaBancaria
        isbanCuentaBancaria  ---> ES6545644654465
        codigo switch de la identidad a la que pertenece ---> nos lo inventaremos
        FK al cliente
        fecha de alta
        fecha de baja

         */

        // Atributos       
        long idCcc;
        string isbanCuentaBancaria = "ES4556545644654465";
        string codigoSwitch = "CSI1SSXX";
        string dniCliente = "123456789l";
        string fchAltaCcc = "9999/12/31";
        string fchBajaCcc = "9999/12/31";

        // Getters y setters
        public long IdCcc { get => idCcc; set => idCcc = value; }
        public string IsbanCuentaBancaria { get => isbanCuentaBancaria; set => isbanCuentaBancaria = value; }
        public string CodigoSwitch { get => codigoSwitch; set => codigoSwitch = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchAltaCcc { get => fchAltaCcc; set => fchAltaCcc = value; }
        public string FchBajaCcc { get => fchBajaCcc; set => fchBajaCcc = value; }


        // Constructores
        public CccDto(long idCcc, string isbanCuentaBancaria, string codigoSwitch, string dniCliente, string fchAltaCcc, string fchBajaCcc)
        {
            this.idCcc = idCcc;
            this.isbanCuentaBancaria = isbanCuentaBancaria;
            this.codigoSwitch = codigoSwitch;
            this.dniCliente = dniCliente;
            this.fchAltaCcc = fchAltaCcc;
            this.fchBajaCcc = fchBajaCcc;
        }

        public CccDto() { 
        }


       override
       public string ToString()
        {
            string cccString = "Iban: " + this.isbanCuentaBancaria + " " +
                "código switch: " + this.codigoSwitch + " " +
                "DNI: " + this.dniCliente + " " +
                "Fecha de alta: " + this.fchAltaCcc + " " +
                "Fecha de baja: " + this.fchBajaCcc;

            return cccString;

        }


    }
}
