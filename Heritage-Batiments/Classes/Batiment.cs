using System;
using System.Collections.Generic;
using System.Text;

namespace Heritage_Batiments.Classes
{
    class Batiment
    {
        private string _adresse;
        private int _superficie;
        private int _nbEtages;
        
        public Batiment(string adresse, int superficie, int nbEtages)
        {
            _adresse = adresse;
            _superficie = superficie;
            _nbEtages = nbEtages;
        }

        public void SetAdresse(string adresse)
        {
            _adresse = adresse;
        }

        public string GetAdresse()
        {
            return _adresse;
        }

        public void SetSuperficie(int superficie)
        {
            _superficie = superficie;
        }

        public int GetSuperficie()
        {
            return _superficie;
        }

        public void SetNbEtages(int nbEtages)
        {
            _nbEtages = nbEtages;
        }

        public int GetNbEtages()
        {
            return _nbEtages;
        }

        public override string ToString()

        {
            string txt = "";
            txt += "L'adresse du bâtiment :" + _adresse + " Superficie : " + _superficie + " mètres carrés Nombre d'étages : " + _nbEtages;
            return txt;
        }




    }
}
