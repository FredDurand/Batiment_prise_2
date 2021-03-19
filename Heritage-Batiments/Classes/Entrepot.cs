using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Batiments.Classes
{
    class Entrepot : Batiment
    {
        private int _nbQuaisChargement;
    
    public Entrepot(string adresse, int superficie, int nbEtages, int nbQuaisChargement) : base(adresse, superficie, nbEtages)
        {
            _nbQuaisChargement = nbQuaisChargement;
        }

        public void SetNbQuaisChargement(int nbQuaisChargement)
        {
            _nbQuaisChargement = nbQuaisChargement;
        }

        public int GetNbQuaisChargement()
        {
            return _nbQuaisChargement;
        }

        public override string ToString()
        {
            return base.ToString() + " Nombre de quais de chargement : " + _nbQuaisChargement;
        }

    }


}
