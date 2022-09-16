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
            //AdicionarOveja();
            //obtenerOveja("Vela");
            //EliminarOveja(1);
            //obtenerOveja(2);
            TraerTodasLasOvejas();
        }

        private static void TraerTodasLasOvejas()
        {
            var goat = _repoOveja.GetAllOvejas();
            Console.WriteLine("Xd");
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
        private static void obtenerOveja(int idoveja)
        {
            var goat = _repoOveja.GetOveja(idoveja);
            Console.WriteLine("yeah motherfucker");
        }

        private static void EliminarOveja(int idoveja)
        {
            _repoOveja.DeleteOveja(idoveja);
            Console.WriteLine("Oveja Eliminada");
        }

    }
}

