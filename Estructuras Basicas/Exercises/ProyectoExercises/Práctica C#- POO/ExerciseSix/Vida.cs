using System;
using PracticaPoo;

namespace PracticaPoo{

    class Vida : ISeguro
    {
        public double MontoBase{get;private set;}
        public int Edad{get;private set;}
        private double MontoAsegurado;

        public Vida(double MontoBase, int Edad){
            this.MontoBase = MontoBase;
            this.Edad = Edad;
        }


        public double CalcularCuotaMensual()
        {
            return MontoAsegurado/12;
        }

        public double CalcularMonto()
        {
            MontoAsegurado = MontoBase*(1+0.05*(65/Edad));
            return MontoAsegurado;
        }
    }

}