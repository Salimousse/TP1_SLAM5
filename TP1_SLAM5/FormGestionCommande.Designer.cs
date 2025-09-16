namespace TP1_SLAM5
{
    partial class FormGestionCommande
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
            txt_montant = new TextBox();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cbClient = new ComboBox();
            label3 = new Label();
            btn_OK = new Button();
            BsClients3 = new BindingSource(components);
            btn_annuler = new Button();
            ((System.ComponentModel.ISupportInitialize)BsClients3).BeginInit();
            SuspendLayout();
            // 
            // txt_montant
            // 
            txt_montant.Location = new Point(346, 55);
            txt_montant.Name = "txt_montant";
            txt_montant.Size = new Size(145, 23);
            txt_montant.TabIndex = 0;
            txt_montant.KeyPress += txt_montant_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 37);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Montant :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(330, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(413, 109);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Date:";
            // 
            // cbClient
            // 
            cbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbClient.FormattingEnabled = true;
            cbClient.Location = new Point(370, 187);
            cbClient.Name = "cbClient";
            cbClient.Size = new Size(121, 23);
            cbClient.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 169);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Choix Clients :";
            // 
            // btn_OK
            // 
            btn_OK.Location = new Point(370, 275);
            btn_OK.Name = "btn_OK";
            btn_OK.Size = new Size(97, 50);
            btn_OK.TabIndex = 6;
            btn_OK.Text = "OK";
            btn_OK.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            btn_annuler.Location = new Point(86, 275);
            btn_annuler.Name = "btn_annuler";
            btn_annuler.Size = new Size(95, 52);
            btn_annuler.TabIndex = 7;
            btn_annuler.Text = "ANNULER";
            btn_annuler.UseVisualStyleBackColor = true;
            btn_annuler.Click += btn_annuler_Click;
            // 
            // FormGestionCommande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_annuler);
            Controls.Add(btn_OK);
            Controls.Add(label3);
            Controls.Add(cbClient);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(txt_montant);
            Name = "FormGestionCommande";
            Text = "Gestion commandes";
            Load += FormGestionCommande_Load;
            ((System.ComponentModel.ISupportInitialize)BsClients3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_montant;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cbClient;
        private Label label3;
        private Button btn_OK;
        private BindingSource BsClients3;
        private Button btn_annuler;
    }
}