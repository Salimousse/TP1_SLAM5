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
            txt_commande = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            // txt_commande
            // 
            txt_commande.Location = new Point(351, 323);
            txt_commande.Name = "txt_commande";
            txt_commande.Size = new Size(123, 23);
            txt_commande.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 299);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 5;
            label3.Text = "Saisir prix commande : ";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 361);
            button1.Name = "button1";
            button1.Size = new Size(109, 55);
            button1.TabIndex = 6;
            button1.Text = "Toutes les commandes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 352);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "filtrer";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txt_commande);
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
        private TextBox txt_commande;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}