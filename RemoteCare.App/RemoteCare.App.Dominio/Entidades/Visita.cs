using System;

namespace RemoteCare.App.Dominio
{
    public class Visita
    {
        public int ID {get;set;}
        public float Temperatura {get;set;}
        public float Peso {get;set;}
        public float Frecuencia_Respiratoria {get;set;}
        public float Frecuencia_Cardiaca {get;set;}
        public enum Estado_Animo {
            Feliz,
            Triste,
        }
        public DateTime fecha {get{ return DateTime.Now; }set{}}
        public int ID_Veterinario {get;set;}
        public string Medicamentos {get;set;}
    }
}