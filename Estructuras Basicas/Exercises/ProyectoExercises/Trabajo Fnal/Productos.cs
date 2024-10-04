using System;

namespace Distribuidora{

    public abstract class Producto{

        public DateTime fechaCaducidad{get;set;}
        public int nroLote{get;set;}
        public DateTime fechaEnvasado{get;set;}
        public required String paisDeOrigen{get;set;}

        public Producto(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen)
        {
            this.fechaCaducidad = fechaCaducidad;
            this.nroLote = nroLote;
            this.fechaEnvasado = fechaEnvasado;
            this.paisDeOrigen = paisDeOrigen;
        }
        
        public Boolean vence30Dias(){
            return DateTime.Now.AddDays(30) > fechaCaducidad;
        }

    }

}