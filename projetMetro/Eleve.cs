using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetMetro
{
    public class Eleve
    {
        protected string nom, prenom, classe, regime, dateNaiss;
        protected static int nbEleveScanne;
        protected ArrayList lesEleves = new ArrayList();
        Eleve unEleve;

        public Eleve(string unNom, string unPrenom, string uneClasse, string unRegime, string uneDateNaiss)
        {
            nom = unNom;
            prenom = unPrenom;
            classe = uneClasse;
            regime = unRegime;
            dateNaiss = uneDateNaiss;
            nbEleveScanne++;
            //Eleve unEleve = new Eleve(this.nom, this.prenom, this.classe, this.regime, this.dateNaiss);
            lesEleves.Add(unEleve);
        }

        public void setNbEleveScannes(int unNb)
        {
            nbEleveScanne = unNb;
        }

        public string getNom()
        {
            return nom;
        }

        public string getPrenom()
        {
            return prenom;
        }

        public string getClasse()
        {
            return classe;
        }

        public string getRegime()
        {
            return regime;
        }

        public string getDateNaiss()
        {
            return dateNaiss;
        }

        public static int getNbEleveScannes()
        {
            return nbEleveScanne;
        }

        public void setNom(string unNom)
        {
            nom = unNom;
        }

        public void setPrenom(string unPrenom)
        {
            prenom = unPrenom;
        }

        public void setClasse(string uneClasse)
        {
            classe = uneClasse;
        }

        public void setRegime(string unRegime)
        {
            regime = unRegime;
        }

        public void setDateNaiss(string uneDateNaiss)
        {
            dateNaiss = uneDateNaiss;
        }

        
    }
}
