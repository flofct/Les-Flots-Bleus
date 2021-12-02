using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class VoilierInscrit: Voilier
    {
        #region Attributs
        private int idCourse;
        private List<Marin> listeMarins = new List<Marin>();
        private List<Sponsor> listeSponsors = new List<Sponsor>();
        #endregion

        #region Propriétés
        public int IdCourse
        {
            get { return idCourse; }
            private set { idCourse = value; }
        }

        public List<Marin> Marins
        {
            get { return new List<Marin>(listeMarins); }
        }

        public List<Sponsor> Sponsors
        {
            get { return new List<Sponsor>(listeSponsors); }
        }
        #endregion

        #region Constructeur
        public VoilierInscrit(int id, string nom, double longueur, double largeur, string materiaux, double poids, int idEquipage, int idEntrepriseSponsor, string sponsor, int idCourse)
            :base(id, nom, longueur, largeur, materiaux, poids, idEquipage, idEntrepriseSponsor, sponsor)
        {
            IdCourse = idCourse;
        }
        #endregion
    }
}
