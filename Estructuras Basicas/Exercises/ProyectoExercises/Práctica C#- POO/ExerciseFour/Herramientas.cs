using System;
using PracticaPoo;

namespace PracticaPoo{
    abstract class Herramientas{
        public string Codigo{get; set;}
        public string Descripcion{get; set;}
        public DateTime FechaUltimaMod{get; set;}

        public abstract bool NecesitaMM(DateTime fecha);



    }
}
