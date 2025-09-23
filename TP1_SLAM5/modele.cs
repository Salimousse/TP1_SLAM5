using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_SLAM5
{
    using System.Net;
    using Microsoft.EntityFrameworkCore;
    using TP1_SLAM5.Entities;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    public static class Modele
    {
        private static BdPartitionsContext monModel;
        public static void init()
        {
            monModel = new BdPartitionsContext();
        }
        public static List<Client> listeClients()
        {
            return monModel.Clients.ToList();
        }

        public static List<Commande> ListeCommandes()
        {
            return monModel.Commandes.Include(a => a.NumcliNavigation).ToList();
        }
        public static List<Commande> listeCommandesParClient(int idClient)
        {
            List<Commande> lesCommandes = monModel.Commandes.Where(p => p.Numcli ==
           idClient).Include(p => p.NumcliNavigation).ToList();
            return lesCommandes;
        }

        public static bool AjoutCommande(int montant, DateTime dateC, int idClient)
        {
            Commande maCommande;

            bool vretour = true;
            try
            {
                maCommande = new Commande();
                maCommande.Montantcde = montant;

                maCommande.Datecde = DateOnly.FromDateTime(dateC.Date);





                maCommande.Numcli = idClient;
                // ajout de l’objet : correspond à un insert
                monModel.Commandes.Add(maCommande); // correspond à un INSERT INTO
                monModel.SaveChanges();






            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
        public static Commande RecupererCommande(int idCommande)
        {
            Commande uneCommande = new Commande();
            try
            {
                uneCommande = monModel.Commandes.Include(c => c.Numparts).First(x =>
               x.Numcde == idCommande);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneCommande;
        }


        public static bool ModifierCommande(int idCommande, int montant, DateTime dateC, int idClient)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = monModel.Commandes.First(x => x.Numcde == idCommande);
                maCommande.Montantcde = montant;
                maCommande.Datecde = DateOnly.FromDateTime(dateC.Date);
                maCommande.Numcli = idClient;
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }

    



        public static bool SupprimerCommande(int idCommande)
        {
            bool vretour = true;
            try
            {
                Commande maCommande = monModel.Commandes.First(x => x.Numcde == idCommande);
                monModel.Commandes.Remove(maCommande);
                monModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }


    }
}
       






