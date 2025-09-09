namespace TP1_SLAM5
{
    public partial class ListeClients : Form
    {
        public ListeClients()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BsClients.DataSource = Modele.listeClients();
            dgvClients.DataSource = BsClients;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_commande_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
