using System;
using PracticaPoo;

namespace PracticaPoo{

    enum Zona {Alta, Media, Baja}

    class Hogar : ISeguro
    {
        private double ValorPropiedad;
        private double MontoAsegurado;
        private Zona zona1;


        public Hogar(double valorPropiedad, double montoAsegurado, Zona zona)
        {
            ValorPropiedad = valorPropiedad;
            MontoAsegurado = montoAsegurado;
            this.zona1 = zona;
        }

        




        public double CalcularCuotaMensual()
        {
            return MontoAsegurado/12;
        }

        public double CalcularMonto()
        {
            

            return MontoAsegurado;
        }
    }

}