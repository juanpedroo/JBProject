using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetMetro
{
    class Eleve
    {
        string nom, prenom, classe, regime, dateNaiss;

        public Eleve(string unNom, string unPrenom, string uneClasse, string unRegime, string uneDateNaiss)
        {
            nom = unNom;
            prenom = unPrenom;
            classe = uneClasse;
            regime = unRegime;
            dateNaiss = uneDateNaiss;
        }
    }
}
