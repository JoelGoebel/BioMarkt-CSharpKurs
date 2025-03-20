namespace ProNaturBiomarkt
{
    partial class RechnungsSuche
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_KundenID_Suche = new System.Windows.Forms.TextBox();
            this.tb_Rechnungsnummer_suche = new System.Windows.Forms.TextBox();
            this.btn_RechnungSuchen = new System.Windows.Forms.Button();
            this.dgv_Rechnungen = new System.Windows.Forms.DataGridView();
            this.btn_RechnungEinsehen = new System.Windows.Forms.Button();
            this.cb_Status_Suche = new System.Windows.Forms.ComboBox();
            this.btn_Rechnungerstellen = new System.Windows.Forms.Button();
            this.btn_backToMainmenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rechnungen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kunden ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rechnungsnummer";
            // 
            // tb_KundenID_Suche
            // 
            this.tb_KundenID_Suche.Location = new System.Drawing.Point(167, 12);
            this.tb_KundenID_Suche.Name = "tb_KundenID_Suche";
            this.tb_KundenID_Suche.Size = new System.Drawing.Size(138, 20);
            this.tb_KundenID_Suche.TabIndex = 3;
            // 
            // tb_Rechnungsnummer_suche
            // 
            this.tb_Rechnungsnummer_suche.Location = new System.Drawing.Point(167, 38);
            this.tb_Rechnungsnummer_suche.Name = "tb_Rechnungsnummer_suche";
            this.tb_Rechnungsnummer_suche.Size = new System.Drawing.Size(138, 20);
            this.tb_Rechnungsnummer_suche.TabIndex = 5;
            // 
            // btn_RechnungSuchen
            // 
            this.btn_RechnungSuchen.Location = new System.Drawing.Point(31, 107);
            this.btn_RechnungSuchen.Name = "btn_RechnungSuchen";
            this.btn_RechnungSuchen.Size = new System.Drawing.Size(273, 21);
            this.btn_RechnungSuchen.TabIndex = 6;
            this.btn_RechnungSuchen.Text = "Suchen";
            this.btn_RechnungSuchen.UseVisualStyleBackColor = true;
            this.btn_RechnungSuchen.Click += new System.EventHandler(this.btn_RechnungSuchen_Click);
            // 
            // dgv_Rechnungen
            // 
            this.dgv_Rechnungen.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dgv_Rechnungen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Rechnungen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Rechnungen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rechnungen.Location = new System.Drawing.Point(12, 149);
            this.dgv_Rechnungen.Name = "dgv_Rechnungen";
            this.dgv_Rechnungen.RowHeadersVisible = false;
            this.dgv_Rechnungen.Size = new System.Drawing.Size(776, 289);
            this.dgv_Rechnungen.TabIndex = 7;
            // 
            // btn_RechnungEinsehen
            // 
            this.btn_RechnungEinsehen.Location = new System.Drawing.Point(393, 105);
            this.btn_RechnungEinsehen.Name = "btn_RechnungEinsehen";
            this.btn_RechnungEinsehen.Size = new System.Drawing.Size(303, 23);
            this.btn_RechnungEinsehen.TabIndex = 8;
            this.btn_RechnungEinsehen.Text = "Rechnung einsehen";
            this.btn_RechnungEinsehen.UseVisualStyleBackColor = true;
            this.btn_RechnungEinsehen.Click += new System.EventHandler(this.btn_RechnungEinsehen_Click);
            // 
            // cb_Status_Suche
            // 
            this.cb_Status_Suche.FormattingEnabled = true;
            this.cb_Status_Suche.Items.AddRange(new object[] {
            "Offen",
            "Bezahlt",
            "Überfällig",
            "Mahnung geschickt"});
            this.cb_Status_Suche.Location = new System.Drawing.Point(167, 64);
            this.cb_Status_Suche.Name = "cb_Status_Suche";
            this.cb_Status_Suche.Size = new System.Drawing.Size(138, 21);
            this.cb_Status_Suche.TabIndex = 9;
            // 
            // btn_Rechnungerstellen
            // 
            this.btn_Rechnungerstellen.Location = new System.Drawing.Point(393, 76);
            this.btn_Rechnungerstellen.Name = "btn_Rechnungerstellen";
            this.btn_Rechnungerstellen.Size = new System.Drawing.Size(303, 23);
            this.btn_Rechnungerstellen.TabIndex = 10;
            this.btn_Rechnungerstellen.Text = "Rechnung erstellen";
            this.btn_Rechnungerstellen.UseVisualStyleBackColor = true;
            this.btn_Rechnungerstellen.Click += new System.EventHandler(this.btn_Rechnungerstellen_Click);
            // 
            // btn_backToMainmenu
            // 
            this.btn_backToMainmenu.Location = new System.Drawing.Point(393, 47);
            this.btn_backToMainmenu.Name = "btn_backToMainmenu";
            this.btn_backToMainmenu.Size = new System.Drawing.Size(303, 23);
            this.btn_backToMainmenu.TabIndex = 11;
            this.btn_backToMainmenu.Text = "Zurück zum Hauptmenü";
            this.btn_backToMainmenu.UseVisualStyleBackColor = true;
            this.btn_backToMainmenu.Click += new System.EventHandler(this.btn_backToMainmenu_Click);
            // 
            // RechnungsSuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_backToMainmenu);
            this.Controls.Add(this.btn_Rechnungerstellen);
            this.Controls.Add(this.cb_Status_Suche);
            this.Controls.Add(this.btn_RechnungEinsehen);
            this.Controls.Add(this.dgv_Rechnungen);
            this.Controls.Add(this.btn_RechnungSuchen);
            this.Controls.Add(this.tb_Rechnungsnummer_suche);
            this.Controls.Add(this.tb_KundenID_Suche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RechnungsSuche";
            this.Text = "RechnungsSuche";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rechnungen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_KundenID_Suche;
        private System.Windows.Forms.TextBox tb_Rechnungsnummer_suche;
        private System.Windows.Forms.Button btn_RechnungSuchen;
        private System.Windows.Forms.DataGridView dgv_Rechnungen;
        private System.Windows.Forms.Button btn_RechnungEinsehen;
        private System.Windows.Forms.ComboBox cb_Status_Suche;
        private System.Windows.Forms.Button btn_Rechnungerstellen;
        private System.Windows.Forms.Button btn_backToMainmenu;
    }
}