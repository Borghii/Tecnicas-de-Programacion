using System;
using PracticaPoo;

namespace PracticaPoo{

    class Automovil : ISeguro
    {


        public double ValorAuto{get;set;}
        public int Año{get;set;}

        private int Antiguedad;
        private double MontoAsegurado;

        public Automovil(double valorAuto, int año)
        {
            ValorAuto = valorAuto;
            Año = año;
            Antiguedad = DateTime.Now.Year - año;

        }



        public double CalcularCuotaMensual()
        {
            return MontoAsegurado/12;
        }

        public double CalcularMonto()
        {
            MontoAsegurado = ValorAuto/Antiguedad;
            return MontoAsegurado;
        }
    }

}