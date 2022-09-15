using System.Collections.Generic;
using RemoteCare.App.Dominio;

namespace RemoteCare.App.Persistencia
{
    public interface InterfaceRepositorioOveja
    {
        IEnumerable<Oveja> GetAllOvejas ();
        Oveja AddOveja(Oveja oveja);
        Oveja UpdateOveja(Oveja oveja);
        void DeleteOveja(int ID);
        Oveja GetOveja(int ID);

    }
}