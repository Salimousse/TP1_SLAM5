using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_SLAM5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dgvCommande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CbClients.ValueMember = "NUMCLI";
            CbClients.DisplayMember = "nomcomplet";
            BsClients2.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            }); ;
            CbClients.DataSource = BsClients2;



            BsCommande.DataSource = Modele.ListeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
            dgvCommande.DataSource = BsCommande;


        }

        private void BsClients2_CurrentChanged(object sender, EventArgs e)
        {
            int IdClient = Convert.ToInt32(CbClients.SelectedValue);
            BsCommande.DataSource = Modele.listeCommandesParClient(IdClient).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
            .OrderBy(x => x.Datecde);
            dgvCommande.DataSource = BsCommande;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_commande_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}// using System;
