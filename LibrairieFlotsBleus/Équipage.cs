using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Équipage
    {
        #region Attributs
        private int id;
        private string nom;
        private int nbeMembres;
        private int idVoilier;
        private int nbeParticipation;
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
        public int NbeMembres
        {
            get { return nbeMembres; }
            set { nbeMembres = value; }
        }
        public int IdVoilier
        {
            get { return idVoilier; }
            private set { idVoilier = value; }
        }
        public int NbeParticipation
        {
            get { return nbeParticipation; }
            set { nbeParticipation = value; }
        }
        #endregion

        #region Constructeur
        public Équipage(int id, string nom, int nbeMembres, int idVoilier, int )
        {
            Id = id;
            Nom = nom;
            NbeMembres = nbeMembres;
            IdVoilier = idVoilier;
        }
        #endregion
    }
}
