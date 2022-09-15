using System.Collections.Generic;
using System.Linq;
using RemoteCare.App.Dominio;
using RemoteCare.App.Persistencia;

namespace RemoteCare.App.Persistencia
{
    public class RepositorioOveja : InterfaceRepositorioOveja
    {
        /// <summary>
        //referencia al contexto de la Oveja
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        ///Metodo constructor
        ///Inyeccion de dependedias para el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioOveja(AppContext appContext)
        {
            _appContext=appContext;
        }


        Oveja InterfaceRepositorioOveja.AddOveja(Oveja oveja)
        {
            var ovejaAdicionada = _appContext.oveja.Add(oveja);
            _appContext.SaveChanges();
            return ovejaAdicionada.Entity;
        }
        
        void InterfaceRepositorioOveja.DeleteOveja(int ID)
        {
           var ovejaEncontrada = _appContext.oveja.FirstOrDefault(o => o.ID == ID);
           if( ovejaEncontrada == null)
           {
            return;
           }
           _appContext.oveja.Remove(ovejaEncontrada);
           _appContext.SaveChanges();
        }

        IEnumerable<Oveja> InterfaceRepositorioOveja.GetAllOvejas()
        {
            return _appContext.oveja;
        }

        Oveja InterfaceRepositorioOveja.GetOveja(int ID)
        {
            return _appContext.oveja.FirstOrDefault(x => x.ID == ID);
        }

        Oveja InterfaceRepositorioOveja.UpdateOveja(Oveja oveja)
        {
            var ovejaEncontrada = _appContext.oveja.FirstOrDefault(o => o.ID == oveja.ID);
            if(oveja!= null)
            {
                ovejaEncontrada.ID = oveja.ID;
                ovejaEncontrada.Nombre = oveja.Nombre;
                ovejaEncontrada.Color = oveja.Color;
                ovejaEncontrada.Especie = oveja.Especie;
                ovejaEncontrada.Raza = oveja.Raza;
                ovejaEncontrada.Veterinario_Asignado = oveja.Veterinario_Asignado;
                ovejaEncontrada.Dueño_Asignado = oveja.Dueño_Asignado;

                _appContext.SaveChanges();
            }
            return ovejaEncontrada;
        }
    }
}