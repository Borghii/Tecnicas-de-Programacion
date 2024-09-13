using System;
using PracticaPoo;

namespace PracticaPoo{

    class Cuadrado(double lado) : Figura
    {
        public double Lado { get; set; } = lado;

        public override double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public override double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }
    }


}