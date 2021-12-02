using System;

namespace LibrairieMétiers
{
    public class Employé
    {
        #region Attributs
        private int id;
        private string nom;
        private string prenom;
        private string role;
        private int identifiant;
        private string mdp;
        private string mail;
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
        public string Prénom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public int Identifiant
        {
            get { return identifiant; }
            private set { identifiant = value; }
        }
        public string MDP
        {
            get { return mdp; }
            private set { mdp = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        #endregion

        #region Constructeur
        public Employé(int id, string nom, string prenom, string role, int identifiant, string mdp, string mail)
        {
            Id = id;
            Nom = nom;
            Prénom = prenom;
            Role = role;
            Identifiant = identifiant;
            MDP = mdp;
            Mail = mail;            
        }
        #endregion
    }
}