using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Marin
    {
        #region Attributs 
        private int id;
        private string nom;
        private string prenom;
        private int age;
        private string role;
        private int idVoilier;
        private int idEquipage;
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
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public int IdVoilier
        {
            get { return idVoilier; }
            set { idVoilier = value; }
        }
        public int IdEquipage
        {
            get { return idEquipage; }
            set { idEquipage = value; }
        }
        #endregion

        #region Constructeur
        public Marin(int id, string nom, string prenom, int age, string role, int idVoilier, int idEquipage)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Role = role;
            IdVoilier = idVoilier;
            IdEquipage = idEquipage;
        }
        #endregion
    }
}
