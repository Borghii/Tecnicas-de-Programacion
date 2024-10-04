using System;

namespace Distribuidora{

    public class Aire : Congelados{

        
        public double coeficiente{get;set;}
        public double temperatura{get;set;}
        public Aire(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen, int tempMantenimiento, int tiempo, double coeficiente, double temperatura) 
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen, tempMantenimiento, tiempo*60)
        {
            this.coeficiente = coeficiente;
            this.temperatura = temperatura;
        }

        public override double calcularTiempoCongelamiento()
        {
            return Convert.ToDouble(tiempo/60) * coeficiente * temperatura ;
        }
    }

}