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




        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
