using Cliente.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Servicios
{
    internal interface CccInterfaz
    {
        /// <summary>
        /// llama al metodo que da de alta una cuenta
        /// 211123 - jzg
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCcc(List<CccDto> listaAntigua);

    }
}
