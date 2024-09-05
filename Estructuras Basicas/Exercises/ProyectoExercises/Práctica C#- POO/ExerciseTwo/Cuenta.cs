using System;
using PracticaPoo;

namespace PracticaPoo{
    class Cuenta{

        private static int ContadorCuenta=0;

        public int _numeroCuenta{ get; }
        public double _saldo{ get;}

        public Cuenta(double Saldo){
            ContadorCuenta++;
            this._numeroCuenta=ContadorCuenta;

            this._saldo=Saldo;
        }


        /*
        public double GetSaldo(){
            return _saldo;
        }

        public int GetNumeroCuenta(){
            return _numeroCuenta;
        }
        */

    }


}