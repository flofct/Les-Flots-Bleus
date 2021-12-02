using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Entreprise
    {
        #region Attributs
        private int id;
        private string nom;
        private int ciret;
        private string domaine;
        private string ss;
        private string mail;
        private int tel;
        private string nomContact;
        private string prenomContact;
        private int idVoilierInscrit;
        private double budget;
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
        public int CIRET
        {
            get { return ciret; }
            private set { ciret = value; }
        }
        public string Domaine
        {
            get { return domaine; }
            set { domaine = value; }
        }
        public string SS
        {
            get { return ss; }
            private set { ss = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public string NomContact
        {
            get { return nomContact; }
            set { nomContact = value; }
        }
        public string PrenomContact
        {
            get { return prenomContact; }
            set { prenomContact = value; }
        }
        public int IdVoilierInscrit
        {
            get { return idVoilierInscrit; }
            set { idVoilierInscrit = value; }
        }
        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public int NbeParticipation
        {
            get { return nbeParticipation; }
            set { nbeParticipation = value; }
        }
        #endregion

        #region Constructeur
        public Entreprise(int id, string nom, int ciret, string domaine, string ss, string mail, int tel, string nomContact, string prenomContact, int idVoilierInscrit, double budget, int nbeParticipation)
        {
            Id = id;
            Nom = nom;
            CIRET = ciret;
            Domaine = domaine;
            SS = ss;
            Mail = mail;
            Tel = tel;
            NomContact = nomContact;
            PrenomContact = prenomContact;
            IdVoilierInscrit = idVoilierInscrit;
            Budget = budget;
            NbeParticipation = nbeParticipation;
        }
        #endregion
    }
}
