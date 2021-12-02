using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class VoilierCourse: Voilier
    {
        #region Attributs
        private DateTime debutCourse;
        private DateTime finCourse;
        private TimeSpan tempsPenalite;
        private TimeSpan tempsBrut;
        private TimeSpan tempsReel;
        #endregion

        #region Propriétés
        public DateTime DebutCourse
        {
            get { return debutCourse; }
            set { debutCourse = value; }
        }
        public DateTime FinCourse
        {
            get { return finCourse; }
            set { finCourse = value; }
        }
        public TimeSpan TempsPenalite
        {
            get { return tempsPenalite; }
            set { tempsPenalite = value; }
        }
        public TimeSpan TempsBrut
        {
            get { return finCourse.Subtract(debutCourse); }
            set { tempsBrut = value; }
        }
        public TimeSpan TempsReel
        {
            get { return tempsBrut + tempsPenalite; }
            set { tempsReel = value; }
        }

        #endregion

        #region Constructeur
        public VoilierCourse(int id, string nom, double longueur, double largeur, string materiaux, double poids, int idEquipage, int idEntrepriseSponsor, string sponsor, DateTime debutCourse, DateTime finCourse, TimeSpan tempsPenalite, TimeSpan tempsBrut, TimeSpan tempsReel)
            : base(id, nom, longueur, largeur, materiaux, poids, idEquipage, idEntrepriseSponsor, sponsor)
        {
            DebutCourse = debutCourse;
            FinCourse = finCourse;
            TempsPenalite = tempsPenalite;
            TempsBrut = tempsBrut;
            TempsReel = tempsReel;
        }
        
        #endregion
    }
}

