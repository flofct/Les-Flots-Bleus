using System;
using System.Collections.Generic;
using System.Text;

namespace LibrairieMétiers
{
    class Association
    {
        #region Attributs
        private List<Voilier> listeVoiliers = new List<Voilier>();
        private List<Entreprise> listeEntreprises = new List<Entreprise>();
        private List<Marin> listeMarins = new List<Marin>();
        private List<VoilierInscrit> listeVoiliersInscrits = new List<VoilierInscrit>();
        private List<VoilierCourse> listeVoiliersCourse = new List<VoilierCourse>();
        private List<Penalite> listePenalites = new List<Penalite>();
        private List<Course> listeCourses = new List<Course>();
        #endregion

        #region CRUD
        #region Ajouter
        public bool AjouterVoilier(Voilier voilier)
        {
            if (voilier == null)
                throw new Exception();

            Voilier v = RechercherVoilier(voilier.Id);
            if (v == null)
            {
                listeVoiliers.Add(voilier);
                v = voilier;
            }

            return false;
        }
        public bool AjouterEntreprise(Entreprise entreprise)
        {
            if (entreprise == null)
                throw new Exception();

            Entreprise e = RechercherEntreprise(entreprise.Id);
            if (e == null)
            {
                listeEntreprises.Add(entreprise);
                e = entreprise;
            }

            return false;
        }
        public bool AjouterMarin(Marin marin)
        {
            if (marin == null)
                throw new Exception();

            Marin m = RechercherMarin(marin.Id);
            if (m == null)
            {
                listeMarins.Add(marin);
                m = marin;
            }

            return false;
        }
        public bool AjouterVoilierInscrit(VoilierInscrit voilierInscrit)
        {
            if (voilierInscrit == null)
                throw new Exception();

            VoilierInscrit v = RechercherVoilierInscrit(voilierInscrit.Id);
            if (v == null)
            {
                listeVoiliersInscrits.Add(voilierInscrit);
                v = voilierInscrit;
            }

            return false;
        }

        public bool AjouterVoilierCourse(VoilierCourse voilierCourse)
        {
            if (voilierCourse == null)
                throw new Exception();

            VoilierCourse v = RechercherVoilierCourse(voilierCourse.Id);
            if (v == null)
            {
                listeVoiliersCourse.Add(voilierCourse);
                v = voilierCourse;
            }

            return false;
        }

        public bool AjouterPenalite(Penalite penalite)
        {
            if (penalite == null)
                throw new Exception();

            Penalite p = RechercherPenalite(penalite.Id);
            if (p == null)
            {
                listePenalites.Add(penalite);
                p = penalite;
            }

            return false;
        }
        public bool AjouterCourse(Course course)
        {
            if (course == null)
                throw new Exception();

            Course c = RechercherCourse(course.Id);
            if (c == null)
            {
                listeCourses.Add(course);
                c = course;
            }

            return false;
        }
        #endregion
        #region Supprimer
        public bool SupprimerVoilier(Voilier voilier)
        {
            if (voilier == null)
                return false;

            return SupprimerVoilier(voilier.Id);
        }
        public bool SupprimerVoilier(int id)
        {
            Voilier v = RechercherVoilier(id);
            if (v == null)
                return false;

            listeVoiliers.Remove(v);
            return true;
        }
        public bool SupprimerEntreprise(Entreprise entreprise)
        {
            if (entreprise == null)
                return false;

            return SupprimerEntreprise(entreprise.Id);
        }
        public bool SupprimerEntreprise(int id)
        {
            Entreprise e = RechercherEntreprise(id);
            if (e == null)
                return false;

            listeEntreprises.Remove(e);
            return true;
        }
        public bool SupprimerMarin(Marin marin)
        {
            if (marin == null)
                return false;

            return SupprimerMarin(marin.Id);
        }
        public bool SupprimerMarin(int id)
        {
            Marin m = RechercherMarin(id);
            if (m == null)
                return false;

            listeMarins.Remove(m);
            return true;
        }
        public bool SupprimerVoilierInscrit(VoilierInscrit voilierInscrit)
        {
            if (voilierInscrit == null)
                return false;

            return SupprimerVoilierInscrit(voilierInscrit.Id);
        }
        public bool SupprimerVoilierInscrit(int id)
        {
            VoilierInscrit v = RechercherVoilierInscrit(id);
            if (v == null)
                return false;

            listeVoiliersInscrits.Remove(v);
            return true;
        }
        public bool SupprimerVoilierCourse(VoilierCourse voilierCourse)
        {
            if (voilierCourse == null)
                return false;

            return SupprimerVoilierCourse(voilierCourse.Id);
        }
        public bool SupprimerVoilierCourse(int id)
        {
            VoilierCourse v = RechercherVoilierCourse(id);
            if (v == null)
                return false;

            listeVoiliersCourse.Remove(v);
            return true;
        }
        public bool SupprimerPenalite(Penalite penalite)
        {
            if (penalite == null)
                return false;

            return SupprimerPenalite(penalite.Id);
        }
        public bool SupprimerPenalite(int id)
        {
            Penalite p = RechercherPenalite(id);
            if (p == null)
                return false;

            listePenalites.Remove(p);
            return true;
        }
        public bool SupprimerCourse(Course course)
        {
            if (course == null)
                return false;

            return SupprimerCourse(course.Id);
        }
        public bool SupprimerCourse(int id)
        {
            Course c = RechercherCourse(id);
            if (c == null)
                return false;

            listeCourses.Remove(c);
            return true;
        }
        #endregion
        #region Modifier
        public bool ModifierVoilier(Voilier voilier)
        {
            if (voilier == null)
                return false;

            Voilier voilierAModifier = RechercherVoilier(voilier.Id);
            if (voilierAModifier == null)
                return false;

            if (voilierAModifier != null)
            {             
                voilierAModifier.Poids = voilier.Poids;
                voilierAModifier.Nom = voilier.Nom;
                voilierAModifier.Longueur = voilier.Longueur;
                voilierAModifier.Largeur = voilier.Largeur;
                voilierAModifier.Materiaux = voilier.Materiaux;
                voilierAModifier.Sponsor = voilier.Sponsor;
            }
            
            return true;
        }
        public bool ModifierEntreprise(Entreprise entreprise)
        {
            if (entreprise == null)
                return false;

            Entreprise entrepriseAModifier = RechercherEntreprise(entreprise.Id);
            if (entrepriseAModifier == null)
                return false;

            if (entrepriseAModifier != null)
            {
                entrepriseAModifier.Domaine = entreprise.Domaine;
                entrepriseAModifier.Nom = entreprise.Nom;
                entrepriseAModifier.Mail = entreprise.Mail;
                entrepriseAModifier.Tel = entreprise.Tel;
                entrepriseAModifier.NomContact = entreprise.NomContact;
                entrepriseAModifier.PrenomContact = entreprise.PrenomContact;
                entrepriseAModifier.Budget = entreprise.Budget;
                entrepriseAModifier.NbeParticipation = entreprise.NbeParticipation;
            }

            return true;
        }
        public bool ModifierMarin(Marin marin)
        {
            if (marin == null)
                return false;

            Marin marinAModifier = RechercherMarin(marin.Id);
            if (marinAModifier == null)
                return false;

            if (marinAModifier != null)
            {
                marinAModifier.Prenom = marin.Prenom;
                marinAModifier.Nom = marin.Nom;
                marinAModifier.Age = marin.Age;
                marinAModifier.Role = marin.Role;
                marinAModifier.IdEquipage = marin.IdEquipage;
                marinAModifier.IdVoilier = marin.IdVoilier;
            }

            return true;
        }
        public bool ModifierVoilierInscrit(VoilierInscrit voilierInscrit)
        {
            if (voilierInscrit == null)
                return false;

            VoilierInscrit voilierInscritAModifier = RechercherVoilierInscrit(voilierInscrit.Id);
            if (voilierInscritAModifier == null)
                return false;

            if (voilierInscritAModifier != null)
            {
                voilierInscritAModifier.Poids = voilierInscrit.Poids;
                voilierInscritAModifier.Nom = voilierInscrit.Nom;
                voilierInscritAModifier.Longueur = voilierInscrit.Longueur;
                voilierInscritAModifier.Largeur = voilierInscrit.Largeur;
                voilierInscritAModifier.Materiaux = voilierInscrit.Materiaux;
                voilierInscritAModifier.Sponsor = voilierInscrit.Sponsor;
            }

            return true;
        }
        public bool ModifierVoilierCourse(VoilierCourse voilierCourse)
        {
            if (voilierCourse == null)
                return false;

            VoilierCourse voilierCourseAModifier = RechercherVoilierCourse(voilierCourse.Id);
            if (voilierCourseAModifier == null)
                return false;

            if (voilierCourseAModifier != null)
            {
                voilierCourseAModifier.Poids = voilierCourse.Poids;
                voilierCourseAModifier.Nom = voilierCourse.Nom;
                voilierCourseAModifier.Longueur = voilierCourse.Longueur;
                voilierCourseAModifier.Largeur = voilierCourse.Largeur;
                voilierCourseAModifier.Materiaux = voilierCourse.Materiaux;
                voilierCourseAModifier.Sponsor = voilierCourse.Sponsor;
            }

            return true;
        }
        public bool ModifierPenalite(Penalite penalite)
        {
            if (penalite == null)
                return false;

            Penalite penaliteAModifier = RechercherPenalite(penalite.Id);
            if (penaliteAModifier == null)
                return false;

            if (penaliteAModifier != null)
            {
                penaliteAModifier.IdVoilier = penalite.IdVoilier;
                penaliteAModifier.Latitude = penalite.Latitude;
                penaliteAModifier.Longitude = penalite.Longitude;
                penaliteAModifier.Duree = penalite.Duree;
            }

            return true;
        }
        public bool ModifierCourse(Course course)
        {
            if (course == null)
                return false;

            Course courseAModifier = RechercherCourse(course.Id);
            if (courseAModifier == null)
                return false;

            if (courseAModifier != null)
            {
                courseAModifier.Nom = course.Nom;                
            }
            return true;
        }
        #endregion
        #endregion

        #region Méthodes de recherche
        public Voilier RechercherVoilier(int id)
        {
            return listeVoiliers.Find(delegate (Voilier voilier)
            {
                return voilier.Id == id;
            });
        }
        public Entreprise RechercherEntreprise(int id)
        {
            return listeEntreprises.Find(delegate (Entreprise entreprise)
            {
                return entreprise.Id == id;
            });
        }
        public Marin RechercherMarin(int id)
        {
            return listeMarins.Find(delegate (Marin marin)
            {
                return marin.Id == id;
            });
        }
        public VoilierInscrit RechercherVoilierInscrit(int id)
        {
            return listeVoiliersInscrits.Find(delegate (VoilierInscrit voilierInscrit)
            {
                return voilierInscrit.Id == id;
            });
        }
        public VoilierCourse RechercherVoilierCourse(int id)
        {
            return listeVoiliersCourse.Find(delegate (VoilierCourse voilierCourse)
            {
                return voilierCourse.Id == id;
            });
        }
        public Penalite RechercherPenalite(int id)
        {
            return listePenalites.Find(delegate (Penalite penalite)
            {
                return penalite.Id == id;
            });
        }
        public Course RechercherCourse(int id)
        {
            return listeCourses.Find(delegate (Course course)
            {
                return course.Id == id;
            });
        }
        #endregion
    }
}
