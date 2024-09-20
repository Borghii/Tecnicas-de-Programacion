using System;
using PracticaPoo;

namespace PracticaPoo{
    class Consulta : Llamada{
       private static int ContadorConsulta = 0;
       public string Motivo{get;set;}
       public int NumeroConsulta{get;set;}

       public Consulta(string Motivo){
            this.Motivo = Motivo;
            
            ContadorConsulta++;
            NumeroConsulta = ContadorConsulta;

       }
    }

}