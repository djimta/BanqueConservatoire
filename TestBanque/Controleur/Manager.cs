using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBanque.DAL;
using TestBanque.Model;

namespace TestBanque.Controleur
{
    class Manager
    {
        private AdherantsDao Adao = new AdherantsDao();

        public List<Adherent> getAdherents()
        {
            return Adao.getAdherents();

        }

    }
}
