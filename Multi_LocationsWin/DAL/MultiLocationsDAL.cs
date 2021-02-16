using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Multi_LocationsWin.DAL;

namespace Multi_LocationsWin
{
    public class MultiLocationsDAL
    {
        private ConnexionEF ContextDb;
        public string message;

        public MultiLocationsDAL()
        {
            ContextDb = new ConnexionEF();
        }

        #region -- Location

        public void AjouterLocation(LocationModel location)
        {
            try
            {
                ContextDb.Connecter();

                var rowsAffected = ContextDb.GetInstanceDb.Insertion_Location(location.DatePaiement, location.MontantMensuel, location.NombrePaiment, location.IDVehicule, location.IDClient, location.IDTerme, location.KmInitial, location.KmFinal);
                ContextDb.SaveChanges();

                message = rowsAffected > 0 ? "Location ajoutée!" : "Erreur pendant l'insertion!";
            }
            catch (Exception e)
            {
                message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }
        }

        public void ModifierLocation(LocationModel location)
        {
            try
            {
                ContextDb.Connecter();

                var rowsAffected = ContextDb.GetInstanceDb.MiseAJour_Location(location.Id, location.DateLocation, location.DatePaiement, location.MontantMensuel, location.NombrePaiment, location.IDVehicule, location.IDClient, location.IDTerme, location.KmInitial, location.KmFinal);
                ContextDb.SaveChanges();

                message = rowsAffected > 0 ? "Location mise à jour!" : "Erreur pendant le mise à jour!";
            }
            catch (Exception e)
            {
                message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }
        }

        public LocationModel GetLocation(int idLocation)
        {
            LocationModel location = new LocationModel();

            try
            {
                ContextDb.Connecter();
                var result = ContextDb.GetInstanceDb.Selection_Location(idLocation).FirstOrDefault();

                if (result != null)
                {
                    location.Id = result.ID;
                    location.DateLocation = result.Date_Location;
                    location.DatePaiement = result.Date_Paiement;
                    location.MontantMensuel = result.Montant_Mensuel.GetValueOrDefault();
                    location.NombrePaiment = result.Nombre_Paiment;
                    location.IDVehicule = result.ID_Vehicule;
                    location.IDClient = result.ID_Client;
                    location.IDTerme = result.ID_Terme;
                    location.KmInitial = result.Km_Initial;
                    location.KmFinal = result.Km_Final;

                }
                else
                    message = $"La location {idLocation} n'existe pas.";
            }
            catch (Exception e)
            {
                this.message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }

            return location;
        }

        #endregion

        #region -- Paiement

        public void EffectuerPaiement(DateTime datePaiement, decimal montant, int idLocation)
        {
            try
            {
                ContextDb.Connecter();
                var rowsAffected = ContextDb.GetInstanceDb.Insertion_Paiement(datePaiement, montant, idLocation, null);
                ContextDb.SaveChanges();

                message = rowsAffected > 0 ? "Paiement effectué!" : "Erreur pendant l'insertion!";
            }
            catch (SqlException e)
            {
                this.message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }
        }

        public void AnnulerPaiement(int idPaiement, string raisonAnnulation)
        {
            try
            {
                ContextDb.Connecter();

                var rowsAffected = ContextDb.GetInstanceDb.Annuler_Paiement(idPaiement, raisonAnnulation);
                ContextDb.SaveChanges();

                message = rowsAffected > 0 ? "Paiement annulé!" : "Erreur pendant le mise à jour!";
            }
            catch (SqlException e)
            {
                this.message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }
        }

        #endregion

        #region -- Login

        public bool ValidateUtilisateur(string utilisateur, string motPasse)
        {
            bool loginValid = false;

            try
            {
                ContextDb.Connecter();

                loginValid = ContextDb.GetInstanceDb.Users.Any(x =>
                    x.Utilisateur == utilisateur && x.MotPasse == motPasse);
            }
            catch (Exception e)
            {
                this.message = "Erreur de connexion à la base de données :" + e.Message;
            }
            finally
            {
                ContextDb.Deconnecter();
            }

            return loginValid;
        }

        #endregion
    }
}
