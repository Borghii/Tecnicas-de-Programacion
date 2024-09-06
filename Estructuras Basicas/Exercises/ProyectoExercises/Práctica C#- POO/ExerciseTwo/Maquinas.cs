using System;
using PracticaPoo;

namespace PracticaPoo{
    class Maquinas : Herramientas{
        public int CantidadUso{get; set;}
        public int HsCalibracion{get; set;}

        public override bool NecesitaMM(DateTime fecha)
        {
            DateTime proxCal = FechaUltimaMod.AddHours(HsCalibracion);
            return fecha > proxCal;
        }
    }
}
