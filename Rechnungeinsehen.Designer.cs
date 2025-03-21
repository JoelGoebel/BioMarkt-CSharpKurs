namespace ProNaturBiomarkt
{
    partial class Rechnungeinsehen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rechnungeinsehen));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_KundenName = new System.Windows.Forms.Label();
            this.lbl_KundenAdress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_RECHNUNG = new System.Windows.Forms.Label();
            this.dgv_RechnungsPositionen = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_zurück = new System.Windows.Forms.Button();
            this.lbl_Faelligkeitsdatum = new System.Windows.Forms.Label();
            this.lbl_Rechnungsdatum = new System.Windows.Forms.Label();
            this.lbl_Rechnungsnummer = new System.Windows.Forms.Label();
            this.lbl_Nettobetrag = new System.Windows.Forms.Label();
            this.lbl_GesamtSumme = new System.Windows.Forms.Label();
            this.lbl_UmsatzSteuer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RechnungsPositionen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProNatur-Biomarkt GmbH";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Musterstraße 3, 38765 Musterstadt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(534, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rechnungsnummer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Zahlungsbedingung";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(400, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rechnungsdatum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(410, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fälligkeitsdatum";
            // 
            // lbl_KundenName
            // 
            this.lbl_KundenName.AutoSize = true;
            this.lbl_KundenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_KundenName.ForeColor = System.Drawing.Color.White;
            this.lbl_KundenName.Location = new System.Drawing.Point(25, 186);
            this.lbl_KundenName.Name = "lbl_KundenName";
            this.lbl_KundenName.Size = new System.Drawing.Size(95, 17);
            this.lbl_KundenName.TabIndex = 7;
            this.lbl_KundenName.Text = "Muster GmbH";
            // 
            // lbl_KundenAdress
            // 
            this.lbl_KundenAdress.AutoSize = true;
            this.lbl_KundenAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_KundenAdress.ForeColor = System.Drawing.Color.White;
            this.lbl_KundenAdress.Location = new System.Drawing.Point(25, 203);
            this.lbl_KundenAdress.Name = "lbl_KundenAdress";
            this.lbl_KundenAdress.Size = new System.Drawing.Size(226, 17);
            this.lbl_KundenAdress.TabIndex = 8;
            this.lbl_KundenAdress.Text = "Musterstraße 4 34567 Musterstadt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(531, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "30 Tage";
            // 
            // lbl_RECHNUNG
            // 
            this.lbl_RECHNUNG.AutoSize = true;
            this.lbl_RECHNUNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_RECHNUNG.ForeColor = System.Drawing.Color.White;
            this.lbl_RECHNUNG.Location = new System.Drawing.Point(12, 272);
            this.lbl_RECHNUNG.Name = "lbl_RECHNUNG";
            this.lbl_RECHNUNG.Size = new System.Drawing.Size(99, 24);
            this.lbl_RECHNUNG.TabIndex = 11;
            this.lbl_RECHNUNG.Text = "Rechnung";
            // 
            // dgv_RechnungsPositionen
            // 
            this.dgv_RechnungsPositionen.AllowUserToAddRows = false;
            this.dgv_RechnungsPositionen.AllowUserToDeleteRows = false;
            this.dgv_RechnungsPositionen.AllowUserToResizeColumns = false;
            this.dgv_RechnungsPositionen.AllowUserToResizeRows = false;
            this.dgv_RechnungsPositionen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RechnungsPositionen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RechnungsPositionen.Location = new System.Drawing.Point(12, 299);
            this.dgv_RechnungsPositionen.Name = "dgv_RechnungsPositionen";
            this.dgv_RechnungsPositionen.RowHeadersVisible = false;
            this.dgv_RechnungsPositionen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_RechnungsPositionen.Size = new System.Drawing.Size(652, 234);
            this.dgv_RechnungsPositionen.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(509, 536);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nettobetrag";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(526, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "UsT 19%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(490, 570);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Gesamtsumme";
            // 
            // btn_zurück
            // 
            this.btn_zurück.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_zurück.ForeColor = System.Drawing.Color.White;
            this.btn_zurück.Location = new System.Drawing.Point(12, 12);
            this.btn_zurück.Name = "btn_zurück";
            this.btn_zurück.Size = new System.Drawing.Size(75, 23);
            this.btn_zurück.TabIndex = 16;
            this.btn_zurück.Text = "zurück";
            this.btn_zurück.UseVisualStyleBackColor = false;
            this.btn_zurück.Click += new System.EventHandler(this.btn_zurück_Click);
            // 
            // lbl_Faelligkeitsdatum
            // 
            this.lbl_Faelligkeitsdatum.AutoSize = true;
            this.lbl_Faelligkeitsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Faelligkeitsdatum.ForeColor = System.Drawing.Color.White;
            this.lbl_Faelligkeitsdatum.Location = new System.Drawing.Point(531, 237);
            this.lbl_Faelligkeitsdatum.Name = "lbl_Faelligkeitsdatum";
            this.lbl_Faelligkeitsdatum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Faelligkeitsdatum.Size = new System.Drawing.Size(80, 17);
            this.lbl_Faelligkeitsdatum.TabIndex = 17;
            this.lbl_Faelligkeitsdatum.Text = "01.01.2000";
            // 
            // lbl_Rechnungsdatum
            // 
            this.lbl_Rechnungsdatum.AutoSize = true;
            this.lbl_Rechnungsdatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Rechnungsdatum.ForeColor = System.Drawing.Color.White;
            this.lbl_Rechnungsdatum.Location = new System.Drawing.Point(531, 203);
            this.lbl_Rechnungsdatum.Name = "lbl_Rechnungsdatum";
            this.lbl_Rechnungsdatum.Size = new System.Drawing.Size(80, 17);
            this.lbl_Rechnungsdatum.TabIndex = 18;
            this.lbl_Rechnungsdatum.Text = "01.01.2000";
            // 
            // lbl_Rechnungsnummer
            // 
            this.lbl_Rechnungsnummer.AutoSize = true;
            this.lbl_Rechnungsnummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Rechnungsnummer.ForeColor = System.Drawing.Color.White;
            this.lbl_Rechnungsnummer.Location = new System.Drawing.Point(531, 186);
            this.lbl_Rechnungsnummer.Name = "lbl_Rechnungsnummer";
            this.lbl_Rechnungsnummer.Size = new System.Drawing.Size(16, 17);
            this.lbl_Rechnungsnummer.TabIndex = 19;
            this.lbl_Rechnungsnummer.Text = "0";
            // 
            // lbl_Nettobetrag
            // 
            this.lbl_Nettobetrag.AutoSize = true;
            this.lbl_Nettobetrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_Nettobetrag.ForeColor = System.Drawing.Color.White;
            this.lbl_Nettobetrag.Location = new System.Drawing.Point(598, 536);
            this.lbl_Nettobetrag.Name = "lbl_Nettobetrag";
            this.lbl_Nettobetrag.Size = new System.Drawing.Size(16, 17);
            this.lbl_Nettobetrag.TabIndex = 20;
            this.lbl_Nettobetrag.Text = "0";
            // 
            // lbl_GesamtSumme
            // 
            this.lbl_GesamtSumme.AutoSize = true;
            this.lbl_GesamtSumme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_GesamtSumme.ForeColor = System.Drawing.Color.White;
            this.lbl_GesamtSumme.Location = new System.Drawing.Point(598, 570);
            this.lbl_GesamtSumme.Name = "lbl_GesamtSumme";
            this.lbl_GesamtSumme.Size = new System.Drawing.Size(16, 17);
            this.lbl_GesamtSumme.TabIndex = 21;
            this.lbl_GesamtSumme.Text = "0";
            // 
            // lbl_UmsatzSteuer
            // 
            this.lbl_UmsatzSteuer.AutoSize = true;
            this.lbl_UmsatzSteuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_UmsatzSteuer.ForeColor = System.Drawing.Color.White;
            this.lbl_UmsatzSteuer.Location = new System.Drawing.Point(598, 553);
            this.lbl_UmsatzSteuer.Name = "lbl_UmsatzSteuer";
            this.lbl_UmsatzSteuer.Size = new System.Drawing.Size(16, 17);
            this.lbl_UmsatzSteuer.TabIndex = 22;
            this.lbl_UmsatzSteuer.Text = "0";
            // 
            // Rechnungeinsehen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(676, 620);
            this.Controls.Add(this.lbl_UmsatzSteuer);
            this.Controls.Add(this.lbl_GesamtSumme);
            this.Controls.Add(this.lbl_Nettobetrag);
            this.Controls.Add(this.lbl_Rechnungsnummer);
            this.Controls.Add(this.lbl_Rechnungsdatum);
            this.Controls.Add(this.lbl_Faelligkeitsdatum);
            this.Controls.Add(this.btn_zurück);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_RechnungsPositionen);
            this.Controls.Add(this.lbl_RECHNUNG);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_KundenAdress);
            this.Controls.Add(this.lbl_KundenName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Rechnungeinsehen";
            this.Text = "Rechnungserstellung";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RechnungsPositionen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_KundenName;
        private System.Windows.Forms.Label lbl_KundenAdress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_RECHNUNG;
        private System.Windows.Forms.DataGridView dgv_RechnungsPositionen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_zurück;
        private System.Windows.Forms.Label lbl_Faelligkeitsdatum;
        private System.Windows.Forms.Label lbl_Rechnungsdatum;
        private System.Windows.Forms.Label lbl_Rechnungsnummer;
        private System.Windows.Forms.Label lbl_Nettobetrag;
        private System.Windows.Forms.Label lbl_GesamtSumme;
        private System.Windows.Forms.Label lbl_UmsatzSteuer;
    }
}