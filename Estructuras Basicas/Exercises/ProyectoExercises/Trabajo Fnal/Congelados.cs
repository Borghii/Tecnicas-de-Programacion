using System;

namespace Distribuidora{

    public abstract class Congelados : Producto{
        public Congelados(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen, int tempMantenimiento, int tiempo) 
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen)
        {
            this.tempMantenimiento = tempMantenimiento;
            this.tiempo=tiempo;
        }

        public int tempMantenimiento{get;set;}
        public int tiempo{get;set;}
        public abstract double calcularTiempoCongelamiento();

    }

}