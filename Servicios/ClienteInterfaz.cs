using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente.Dtos;

namespace Cliente.Servicios
{
    internal interface ClienteInterfaz
    {

        public void darAltaCliente( List<ClienteDto> listaAntigua);

    }
}
