using System;
using PracticaPoo;

namespace PracticaPoo{
    class Consulta : Llamada{
       private static int ContadorConsulta = 0;
       public string Motivo{get;set;}
       public int NumeroConsulta{get;set;}

        public Consulta(int numeroAbonado, int numeroOperador, DateTime fechaHorallamada, string Motivo)
            : base(numeroAbonado, numeroOperador, fechaHorallamada){
        

            this.Motivo = Motivo;

            ContadorConsulta++;
            NumeroConsulta = ContadorConsulta;

       }
    }

}