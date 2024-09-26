using System;
using PracticaPoo;

namespace PracticaPoo{
    class RegistradorLlamadas{

    private int ContadorConsultas = 0;
    private int ReclamosResueltosOperador = 0;
    private int ReclamosResueltosEspecialista = 0;


    private List<Llamada> LlamadasRecibidas = new List<Llamada>();
    static void Main(string[] args)
    {
        Console.Clear();
        RegistradorLlamadas registradorLlamadas = new RegistradorLlamadas();

        
        DateTime fechaHorallamada1 = DateTime.Now;
        DateTime fechaHorallamada2 = DateTime.Now.AddMinutes(5);  
        DateTime fechaHorallamada3 = DateTime.Now.AddMinutes(10);
        DateTime fechaHorallamada4 = DateTime.Now.AddMinutes(15);
        DateTime fechaHorallamada5 = DateTime.Now.AddMinutes(20);

       
        Llamada llamada1 = new Consulta(12345, 678, fechaHorallamada1, "Cobro de impuestos");
        registradorLlamadas.RegistrarLlamada(llamada1);

        Llamada llamada2 = new Reclamo(23456, 679, fechaHorallamada2, "Cobro de beca");
        registradorLlamadas.RegistrarLlamada(llamada2);

        Llamada llamada3 = new Reclamo(34567, 680, fechaHorallamada3, "Cobro de subsidio", "4872384923");
        registradorLlamadas.RegistrarLlamada(llamada3);

        Llamada llamada4 = new Reclamo(45678, 681, fechaHorallamada4, "Cobro de seguro", "45345435");
        registradorLlamadas.RegistrarLlamada(llamada4);

        Llamada llamada5 = new DebitoAutomatico(56789, 682, fechaHorallamada5, "Cobro de comida", 3423423);
        registradorLlamadas.RegistrarLlamada(llamada5);

        registradorLlamadas.ResumenDiario();

    }

    public void RegistrarLlamada(Llamada llamada){

        if(llamada is Consulta){
            ContadorConsultas++;
        }

        if(llamada is Reclamo){

            Reclamo reclamo = (Reclamo)llamada;

            if(reclamo.NumeroEspecialista==null) {
                ReclamosResueltosOperador++;
            }else{
                ReclamosResueltosEspecialista++;
            }
        }

        LlamadasRecibidas.Add(llamada);

    }

    public void ResumenDiario(){
        Console.WriteLine("Numero de llamadas: "+ LlamadasRecibidas.Count);
        Console.WriteLine("Numero de consultas: "+ ContadorConsultas);
        Console.WriteLine("Numero de reclamos resultos operador: "+ ReclamosResueltosOperador);
        Console.WriteLine("Numero de reclamos resultos especialista:"+ ReclamosResueltosEspecialista);
    }






    }

}