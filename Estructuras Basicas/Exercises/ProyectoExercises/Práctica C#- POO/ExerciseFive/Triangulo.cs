using System;
using PracticaPoo;

namespace PracticaPoo{

    class Triangulo(double altura, double @base, double lado1, double lado2, double lado3) : Figura
    {

        public double Altura { get; set; } = altura;
        public double Base { get; set; } = @base;
        public double Lado1 { get; set; } = lado1;
        public double Lado2 { get; set; } = lado2;
        public double Lado3 { get; set; } = lado3;

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