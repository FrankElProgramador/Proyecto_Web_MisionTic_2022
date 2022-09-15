using System;

namespace RemoteCare.App.Dominio
{
    public class Oveja
    {
        public int ID {get;set;}
        public string Nombre {get;set;}
        public string Color {get;set;}
        public string Especie {get;set;}
        public string Raza {get;set;}
        public int Veterinario_Asignado {get;set;}
        public int Dueño_Asignado {get;set;}
    }
}