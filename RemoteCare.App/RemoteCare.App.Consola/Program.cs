using System;
using RemoteCare.App.Dominio;
using RemoteCare.App.Persistencia;
namespace RemoteCare.App.Consola
{
    class Program
    {
        private static InterfaceRepositorioOveja _repoOveja = new RepositorioOveja(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bitches");
            //AddOveja();
            //obtenerOveja("Vela");
            //EliminarOveja(1,1);
            int ID = 2;
            obtenerOveja(ID);
        }

        //añadir objeto a la BD
        private static void AdicionarOveja()
        {
            var oveja = new Oveja
            {
                Nombre = "Gold Friend",
                Color = "Vela",
                Especie = "O. orientalis",
                Raza = "Dorper",
                Veterinario_Asignado = 03,
                Dueño_Asignado = 03
            };
            _repoOveja.AddOveja(oveja);
        }

        //Buscar Objeto en la BD
        private static void obtenerOveja(int ID)
        {
            var goat = _repoOveja.GetOveja(ID);
            Console.WriteLine("yeah motherfucker");
        }

        private static void EliminarOveja(int ID)
        {
            _repoOveja.DeleteOveja(ID);
            Console.WriteLine("Oveja Eliminada");
        }

    }
}

