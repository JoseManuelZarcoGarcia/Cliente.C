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
        /// <summary>
        /// llama al metodo que da de alta a un cliente
        /// 211123 - jzg
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCliente( List<ClienteDto> listaAntigua);

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public void borrarCliente(List<ClienteDto> listaAntigua);

    }
}
