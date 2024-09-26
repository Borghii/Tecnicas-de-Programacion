using System;
using PracticaPoo;

namespace PracticaPoo{
    class Reclamo : Llamada{

       private static int ContadorReclamos = 0;
       public string Motivo{get;set;}
       public String? NumeroEspecialista {get;set;}
       public int NumeroReclamo{get;private set;}

        public Reclamo(int numeroAbonad, int numeroOperador, DateTime fechaHorallamada, string Motivo, string NumeroEspecialista) 
            : base(numeroAbonad, numeroOperador, fechaHorallamada){
        
        this.Motivo = Motivo;
        this.NumeroEspecialista = NumeroEspecialista;

        ContadorReclamos++;
        NumeroReclamo = ContadorReclamos;

       }

      public Reclamo(int numeroAbonado, int numeroOperador, DateTime fechaHorallamada, string Motivo)
           : base(numeroAbonado, numeroOperador, fechaHorallamada)
           {

        this.Motivo = Motivo;
        this.NumeroEspecialista = null;

        ContadorReclamos++;
        NumeroReclamo = ContadorReclamos;

       }

    }

}