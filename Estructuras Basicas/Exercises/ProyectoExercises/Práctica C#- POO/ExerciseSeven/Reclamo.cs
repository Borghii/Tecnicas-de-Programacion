using System;
using PracticaPoo;

namespace PracticaPoo{
    class Reclamo : Llamada{

       private static int ContadorReclamos = 0;
       public string Motivo{get;set;}
       public String? NumeroEspecialista {get;set;}
       public int NumeroReclamo{get;private set;}

       public Reclamo(string Motivo, string NumeroEspecialista){

        this.Motivo = Motivo;
        this.NumeroEspecialista = NumeroEspecialista;

        ContadorReclamos++;
        NumeroReclamo = ContadorReclamos;

       }

        public Reclamo(string Motivo){

        this.Motivo = Motivo;
        this.NumeroEspecialista = null;

        ContadorReclamos++;
        NumeroReclamo = ContadorReclamos;

       }

    }

}