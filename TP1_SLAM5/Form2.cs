using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1_SLAM5.Entities;

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






        private void button1_Click(object sender, EventArgs e)
        {
            BsCommande.DataSource = Modele.ListeCommandes().Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BsCommande.DataSource = Modele.listeCommandesParClient(Convert.ToInt32(CbClients.SelectedValue)).Select(x => new
            {
                x.Numcde,
                x.Datecde,
                x.Montantcde,
                x.NumcliNavigation.Nomcli,
                x.NumcliNavigation.Prenomcli
            })
                .Where(x => x.Montantcde >= Convert.ToInt32(txt_commande.Text));
            dgvCommande.DataSource = BsCommande;
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            FormGestionCommande formGestionCommande = new FormGestionCommande();
            formGestionCommande.ShowDialog();
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (dgvCommande.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une commande à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idCommande = Convert.ToInt32(dgvCommande.CurrentRow.Cells["Numcde"].Value);
            Commande commandeAModifier = Modele.RecupererCommande(idCommande);

            if (commandeAModifier == null)
            {
                MessageBox.Show("La commande sélectionnée n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormGestionCommande formGestionCommande = new FormGestionCommande(commandeAModifier); // Mode modification
            if (formGestionCommande.ShowDialog() == DialogResult.OK)
            {
                // Rafraîchir la liste des commandes après modification
                BsCommande.DataSource = Modele.ListeCommandes().Select(x => new
                {
                    x.Numcde,
                    x.Datecde,
                    x.Montantcde,
                    x.NumcliNavigation.Nomcli,
                    x.NumcliNavigation.Prenomcli
                });
                dgvCommande.DataSource = BsCommande;
            }

        }

    }



}

