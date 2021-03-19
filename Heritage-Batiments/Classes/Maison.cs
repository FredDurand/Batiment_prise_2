using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Batiments.Classes
{
    class Maison : Batiment
    {
        private int _nbChambres;
        private string _revetement;

        public Maison(string adresse, int superficie, int nbEtages, int nbChambres, string revetement) : base(adresse, superficie, nbEtages)
        {
            _nbChambres = nbChambres;
            _revetement = revetement;
        }

        public void SetNbChambres(int nbChambres)
        {
            _nbChambres = nbChambres;
        }

        public int GetNbChambres()
        {
            return _nbChambres;
        }

        public override string ToString()
        {
            return base.ToString() + " Nombre de chambres : " + _nbChambres + " Revêtement : " + _revetement;
        }


    }
}
