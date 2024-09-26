using System;
using PracticaPoo;

namespace PracticaPoo{
    class DebitoAutomatico : Llamada{
        public DebitoAutomatico(int numeroAbonado, int numeroOperador, DateTime fechaHorallamada, string nombreEntidad, int numeroCuenta)
            : base(numeroAbonado, numeroOperador, fechaHorallamada)
        {
            NombreEntidad = nombreEntidad;
            NumeroCuenta = numeroCuenta;
        }

        public string NombreEntidad{get;set;}
        public int NumeroCuenta{get;set;}

    

    }

}