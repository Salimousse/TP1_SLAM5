using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_SLAM5
{
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
            return monModel.Commandes.ToList();
        }



    }
}
