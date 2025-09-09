using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_SLAM5
{
    using Microsoft.EntityFrameworkCore;
    using TP1_SLAM5.Entities;
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



    }
}
