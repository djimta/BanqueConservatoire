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
        private InscriptionDao Idao = new InscriptionDao();
        private Adherent Adherent = new Adherent(1, null, null);
        public List<Adherent> getAdherents()
        {
            return Adao.getAdherents();

        }

        public List<Inscritption> chargementDbInsc(Adherent adherent)
        {
            return Idao.getInscritptions(adherent);

        }
        public bool ChargementDbPaye(Inscritption inscritption)
        {
            return inscritption.insciPayee();
        }

    }
}
