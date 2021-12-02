using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Voilier
    {
        #region Attributs
        private int id;
        private string nom;
        private double longueur;
        private double largeur;
        private string materiaux;
        private double poids;
        private int idEquipage;
        private int idEntrepriseSponsor;
        private string sponsor;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }
        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }
        public string Materiaux
        {
            get { return materiaux; }
            set { materiaux = value; }
        }
        public double Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public int IdEquipage
        {
            get { return idEquipage; }
            private set { idEquipage = value; }
        }
        public int IdEntrepriseSponsor
        {
            get { return idEntrepriseSponsor; }
            private set { idEntrepriseSponsor = value; }
        }
        public string Sponsor
        {
            get { return sponsor; }
            set { sponsor = value; }
        }
        #endregion

        #region Constructeur
        public Voilier(int id, string nom, double longueur, double largeur, string materiaux, double poids, int idEquipage, int idEntrepriseSponsor, string sponsor)
        {
            Id = id;
            Nom = nom;
            Longueur = longueur;
            Largeur = largeur;
            Materiaux = materiaux;
            Poids = poids;
            IdEquipage = idEquipage;
            IdEntrepriseSponsor = idEntrepriseSponsor;
            Sponsor = sponsor;
        }
        #endregion
    }
}
