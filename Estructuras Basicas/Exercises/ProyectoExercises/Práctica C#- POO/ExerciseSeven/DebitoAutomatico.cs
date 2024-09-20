using System;
using PracticaPoo;

namespace PracticaPoo{
    class DebitoAutomatico : Llamada{
        public DebitoAutomatico(string nombreEntidad, int numeroCuenta)
        {
            NombreEntidad = nombreEntidad;
            NumeroCuenta = numeroCuenta;
        }

        public string NombreEntidad{get;set;}
        public int NumeroCuenta{get;set;}

    

    }

}