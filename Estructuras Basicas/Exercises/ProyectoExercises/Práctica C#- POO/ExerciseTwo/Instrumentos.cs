using System;
using PracticaPoo;

namespace PracticaPoo{
    class Instrumentos : Herramientas{
        public string UnidadMedida{get;set;}
        public int MesesCalibracion{get;set;}

        public override bool NecesitaMM(DateTime fecha)
        {
            DateTime proxCalibracion = FechaUltimaMod.AddMonths(MesesCalibracion);
            return fecha > proxCalibracion;
        }
    }
}