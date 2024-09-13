using System;
using PracticaPoo;

namespace PracticaPoo{

    class Complejo{

        public int ParteReal{get; set;}
        public int ParteImaginaria{get;private set;}

        public Complejo(int ParteReal, int ParteImaginaria){
            this.ParteReal=ParteReal;
            this.ParteImaginaria=ParteImaginaria;
        }

        public Complejo(){
            this.ParteReal=0;
            this.ParteImaginaria=0;
        }

        public override string ToString(){
            return ParteReal+"+"+ParteImaginaria+"i";
        }

        public static Complejo operator + (Complejo a,  Complejo b){
        
            return new Complejo(a.ParteReal + b.ParteReal, a.ParteImaginaria + b.ParteImaginaria);
        }

        public static Complejo operator - (Complejo a,  Complejo b){
            return new Complejo(a.ParteReal - b.ParteReal, a.ParteImaginaria - b.ParteImaginaria);
        }




    }
}