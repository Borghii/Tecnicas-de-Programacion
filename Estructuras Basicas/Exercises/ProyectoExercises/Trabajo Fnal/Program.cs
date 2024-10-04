using System;

namespace Distribuidora{

    class Program{

        List<Producto> productos = new List<Producto>();

        static void Main(string[] args)
        {


        }

        public List<Producto> listaProductosVenceMenos30Dias(){
            List<Producto> list = new List<Producto>();
            foreach(Producto producto in productos){
                if(producto.vence30Dias()){
                    list.Add(producto);
                }
            }
            return list;
        }


        public double promedioCongelamientoProductosCongelados(){

            double sumaTiempos=0;
            int cantProductosCongelados=0;

            foreach(Producto producto in productos){

                if(producto is Congelados){
                    cantProductosCongelados++;
                    sumaTiempos+=((Congelados)producto).calcularTiempoCongelamiento();
                }

            }

            return sumaTiempos/cantProductosCongelados;

        }



        
    }



}