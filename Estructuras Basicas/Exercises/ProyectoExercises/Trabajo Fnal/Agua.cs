using System;

namespace Distribuidora{

    public class Agua : Congelados
    {
        public double coeficiente{get;set;}
        public Agua(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen, int tempMantenimiento, int tiempo, double coeficiente) 
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen, tempMantenimiento, tiempo*60)
        {
            this.coeficiente = coeficiente;
        }

        public override double calcularTiempoCongelamiento()
        {
            return (Convert.ToDouble(tiempo/60)+15) * coeficiente;
        }
    }

}