using System;
using PracticaPoo;

namespace PracticaPoo{
    class Cliente{

        private String _dni;
        private String _nombre;
        private String _apellido;
        private Cuenta _cuenta;

        public Cliente(String Dni, String Nombre, String Apellido,Cuenta cuenta ){
            this._dni=Dni;
            this._nombre=Nombre;
            this._apellido=Apellido;
            this._cuenta=cuenta;
        }

        public void MostrarSaldo(){
            Console.WriteLine("El saldo del usuario con id "+_cuenta._numeroCuenta +" es: "+_cuenta._saldo);
        }




    }

}