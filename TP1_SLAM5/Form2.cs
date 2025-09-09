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
            BsCommande.DataSource = Modele.ListeCommandes().Select(x => new
            {
                x.Numcde,
                x.Montantcde,
                x.Datecde
            });
            dgvCommande.DataSource = BsCommande;


        }
    }
}
