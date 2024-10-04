using System;

namespace Distribuidora{

    public class Nitrogeno : Congelados
    {
        public Nitrogeno(DateTime fechaCaducidad, int nroLote, DateTime fechaEnvasado, string paisDeOrigen, int tempMantenimiento, int tiempo) 
        : base(fechaCaducidad, nroLote, fechaEnvasado, paisDeOrigen, tempMantenimiento, tiempo)
        {

        }

        public override double calcularTiempoCongelamiento()
        {
            return Convert.ToDouble(tiempo/60);
        }
    }

}