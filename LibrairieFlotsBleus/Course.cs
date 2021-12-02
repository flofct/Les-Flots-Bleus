using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Course
    {
        #region Attributs
        private int id;
        private string nom;
        private List<VoilierInscrit> listeVoiliersInscrits = new List<VoilierInscrit>();
        private List<VoilierCourse> listeVoiliersCourse = new List<VoilierCourse>();
        #endregion

        #region Propriétés 
        public int Id
        {
            get { return id;}
            private set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<VoilierInscrit> VoilierInscrits
        {
            get { return new List<VoilierInscrit>(listeVoiliersInscrits); }
        }
        public List<VoilierCourse> VoilierCourse
        {
            get { return new List<VoilierCourse>(listeVoiliersCourse); }
        }
        #endregion

        #region Constructeur

        public Course(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        #endregion
    }
}
