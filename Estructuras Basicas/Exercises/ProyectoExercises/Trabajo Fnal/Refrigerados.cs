using System;

namespace Distribuidora{

    class Refrigerados : Producto
    {
        public Refrigerados(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen, int codigoSupersion, int temperatura)
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen)
        {
            this.codigoSupersion = codigoSupersion;
            this.temperatura = temperatura;
        }

        public int codigoSupersion{get;set;}
        public int temperatura{get;set;}

    
    }

}