using System;
using PracticaPoo;

namespace PracticaPoo{
    class Rectangulo(double largo, double ancho) : Figura
    {
        public double Largo { get; set; } = largo;
        public double Ancho { get; set; } = ancho;

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