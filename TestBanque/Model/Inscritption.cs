using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBanque.Model
{
    class Inscritption
    {
        private Adherent unAdherent;
        private Cours unCours;

        private int payee;


        public Inscritption(Adherent unAdherent, Cours unCours, int payee = 1)
        {
            this.unAdherent = unAdherent;
            this.unCours = unCours;
            this.payee = payee;
        }

        public bool insciPayee()
        {
            if (this.payee == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public int Payee { get => payee; }
        public Adherent Adherent { get => unAdherent; }

        public Cours Cours { get => unCours; }
        public override string ToString()
        {
            return ("Cours :"+ unCours.NomInstru);
        }
    }
}
