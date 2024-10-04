using System;

namespace Distribuidora{

    class Frescos : Producto
    {
        public Frescos(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen) 
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen)
        {

        }
    }

}