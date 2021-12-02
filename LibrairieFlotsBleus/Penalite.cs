using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Penalite
    {
        #region Attributs
        private int id;
        private int idVoilier;
        private string latitude;
        private string longitude;
        private DateTime duree;
        #endregion

        #region Propriétés
        public int Id
        {
            get { return id; }
            private set { Id = value; }
        }
        public int IdVoilier
        {
            get { return idVoilier; }
            set { idVoilier = value; }
        }
        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }
        public DateTime Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        #endregion

        #region Constructeur
        public Penalite(int id, int idVoilier, string latitude, string longitude, DateTime duree)
        {
            Id = id;
            IdVoilier = idVoilier;
            Latitude = latitude;
            Longitude = longitude;
            Duree = duree;            
        }
        #endregion
    }
}
