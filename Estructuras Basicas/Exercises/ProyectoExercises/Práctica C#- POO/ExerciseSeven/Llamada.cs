using System;
using PracticaPoo;

namespace PracticaPoo{
    abstract class Llamada{
        public Llamada(int numeroAbonado, int numeroOperador, DateTime fechaHorallamada)
        {
            NumeroAbonado = numeroAbonado;
            NumeroOperador = numeroOperador;
            FechaHorallamada = fechaHorallamada;
        }

        public int NumeroAbonado{get;set;}
        public int NumeroOperador{get;set;}
        public DateTime FechaHorallamada{get;set;}


    }

}