namespace TP1_SLAM5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvCommande = new DataGridView();
            BsCommande = new BindingSource(components);
            CbClients = new ComboBox();
            label2 = new Label();
            BsClients2 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BsCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BsClients2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 57);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Liste des commandes";
            // 
            // dgvCommande
            // 
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCommande.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommande.Location = new Point(120, 107);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.Size = new Size(542, 150);
            dgvCommande.TabIndex = 1;
            dgvCommande.CellContentClick += dgvCommande_CellContentClick;
            // 
            // CbClients
            // 
            CbClients.FormattingEnabled = true;
            CbClients.Location = new Point(565, 361);
            CbClients.Name = "CbClients";
            CbClients.Size = new Size(153, 23);
            CbClients.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(589, 331);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Liste des clients :";
            // 
            // BsClients2
            // 
            BsClients2.CurrentChanged += BsClients2_CurrentChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(CbClients);
            Controls.Add(dgvCommande);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Liste des commandes";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)BsCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)BsClients2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvCommande;
        private BindingSource BsCommande;
        private ComboBox CbClients;
        private Label label2;
        private BindingSource BsClients2;
    }
}