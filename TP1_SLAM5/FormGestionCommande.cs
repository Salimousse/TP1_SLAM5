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
    public partial class FormGestionCommande : Form
    {
        public FormGestionCommande()
        {
            InitializeComponent();
        }



        private void FormGestionCommande_Load(object sender, EventArgs e)
        {
            cbClient.ValueMember = "NUMCLI";
            cbClient.DisplayMember = "nomcomplet";
            BsClients3.DataSource = (Modele.listeClients()).Select(x => new
            {
                x.Numcli,
                nomComplet = x.Nomcli + " " + x.Prenomcli
            }); ;
            cbClient.DataSource = BsClients3;
            cbClient.SelectedIndex = -1;






        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txt_montant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {

                {
                    MessageBox.Show("Erreur, vous devez saisir des entiers", "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    e.Handled = true; // efface le dernier caractère saisi
                }


            }
        }

        private void DT1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if (cbClient.SelectedIndex == -1)
            {
                MessageBox.Show("Erreur, vous devez choisir un client", "Erreur", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (Modele.AjoutCommande(Convert.ToInt32(txt_montant.Text), DT1.Value, Convert.ToInt32(cbClient.SelectedValue)) == false)
            {
                MessageBox.Show("Erreur, l'ajout de la commande a échoué", "Erreur", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Ajout de la commande effectué", "Ajout", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}

