namespace ProNaturBiomarkt
{
    partial class ProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Marke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Preis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Kategorie = new System.Windows.Forms.ComboBox();
            this.btn_ProductSave = new System.Windows.Forms.Button();
            this.btn_ProductEdit = new System.Windows.Forms.Button();
            this.btn_ProductClear = new System.Windows.Forms.Button();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.dgw_ProductTable = new System.Windows.Forms.DataGridView();
            this.btn_BackToMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.ForeColor = System.Drawing.Color.White;
            this.tb_Name.Location = new System.Drawing.Point(82, 11);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(276, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Marke
            // 
            this.tb_Marke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tb_Marke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Marke.ForeColor = System.Drawing.Color.White;
            this.tb_Marke.Location = new System.Drawing.Point(82, 37);
            this.tb_Marke.Name = "tb_Marke";
            this.tb_Marke.Size = new System.Drawing.Size(276, 20);
            this.tb_Marke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // tb_Preis
            // 
            this.tb_Preis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tb_Preis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Preis.ForeColor = System.Drawing.Color.White;
            this.tb_Preis.Location = new System.Drawing.Point(82, 89);
            this.tb_Preis.Name = "tb_Preis";
            this.tb_Preis.Size = new System.Drawing.Size(276, 20);
            this.tb_Preis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // cb_Kategorie
            // 
            this.cb_Kategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cb_Kategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Kategorie.ForeColor = System.Drawing.Color.White;
            this.cb_Kategorie.FormattingEnabled = true;
            this.cb_Kategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.cb_Kategorie.Location = new System.Drawing.Point(82, 62);
            this.cb_Kategorie.Name = "cb_Kategorie";
            this.cb_Kategorie.Size = new System.Drawing.Size(276, 21);
            this.cb_Kategorie.TabIndex = 8;
            // 
            // btn_ProductSave
            // 
            this.btn_ProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_ProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductSave.ForeColor = System.Drawing.Color.White;
            this.btn_ProductSave.Location = new System.Drawing.Point(79, 127);
            this.btn_ProductSave.Name = "btn_ProductSave";
            this.btn_ProductSave.Size = new System.Drawing.Size(89, 23);
            this.btn_ProductSave.TabIndex = 9;
            this.btn_ProductSave.Text = "Speichern";
            this.btn_ProductSave.UseVisualStyleBackColor = false;
            this.btn_ProductSave.Click += new System.EventHandler(this.btn_ProductSave_Click);
            // 
            // btn_ProductEdit
            // 
            this.btn_ProductEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_ProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductEdit.ForeColor = System.Drawing.Color.White;
            this.btn_ProductEdit.Location = new System.Drawing.Point(174, 127);
            this.btn_ProductEdit.Name = "btn_ProductEdit";
            this.btn_ProductEdit.Size = new System.Drawing.Size(89, 23);
            this.btn_ProductEdit.TabIndex = 10;
            this.btn_ProductEdit.Text = "Bearbeiten";
            this.btn_ProductEdit.UseVisualStyleBackColor = false;
            this.btn_ProductEdit.Click += new System.EventHandler(this.btn_ProductEdit_Click);
            // 
            // btn_ProductClear
            // 
            this.btn_ProductClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_ProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductClear.ForeColor = System.Drawing.Color.White;
            this.btn_ProductClear.Location = new System.Drawing.Point(269, 127);
            this.btn_ProductClear.Name = "btn_ProductClear";
            this.btn_ProductClear.Size = new System.Drawing.Size(89, 23);
            this.btn_ProductClear.TabIndex = 11;
            this.btn_ProductClear.Text = "Felder leeren";
            this.btn_ProductClear.UseVisualStyleBackColor = false;
            this.btn_ProductClear.Click += new System.EventHandler(this.btn_ProductClear_Click);
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_ProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ProductDelete.ForeColor = System.Drawing.Color.White;
            this.btn_ProductDelete.Location = new System.Drawing.Point(364, 127);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(89, 23);
            this.btn_ProductDelete.TabIndex = 12;
            this.btn_ProductDelete.Text = "Löschen";
            this.btn_ProductDelete.UseVisualStyleBackColor = false;
            this.btn_ProductDelete.Click += new System.EventHandler(this.btn_ProductDelete_Click);
            // 
            // dgw_ProductTable
            // 
            this.dgw_ProductTable.AllowUserToAddRows = false;
            this.dgw_ProductTable.AllowUserToDeleteRows = false;
            this.dgw_ProductTable.AllowUserToResizeColumns = false;
            this.dgw_ProductTable.AllowUserToResizeRows = false;
            this.dgw_ProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_ProductTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dgw_ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ProductTable.Location = new System.Drawing.Point(12, 156);
            this.dgw_ProductTable.MultiSelect = false;
            this.dgw_ProductTable.Name = "dgw_ProductTable";
            this.dgw_ProductTable.ReadOnly = true;
            this.dgw_ProductTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgw_ProductTable.RowHeadersVisible = false;
            this.dgw_ProductTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgw_ProductTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgw_ProductTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.dgw_ProductTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_ProductTable.Size = new System.Drawing.Size(775, 293);
            this.dgw_ProductTable.TabIndex = 13;
            this.dgw_ProductTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ProductTable_CellContentClick);
            // 
            // btn_BackToMainMenu
            // 
            this.btn_BackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_BackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToMainMenu.ForeColor = System.Drawing.Color.White;
            this.btn_BackToMainMenu.Location = new System.Drawing.Point(459, 127);
            this.btn_BackToMainMenu.Name = "btn_BackToMainMenu";
            this.btn_BackToMainMenu.Size = new System.Drawing.Size(328, 23);
            this.btn_BackToMainMenu.TabIndex = 14;
            this.btn_BackToMainMenu.Text = "Zurück zum Hauptmenü";
            this.btn_BackToMainMenu.UseVisualStyleBackColor = false;
            this.btn_BackToMainMenu.Click += new System.EventHandler(this.btn_BackToMainMenu_Click);
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.btn_BackToMainMenu);
            this.Controls.Add(this.dgw_ProductTable);
            this.Controls.Add(this.btn_ProductDelete);
            this.Controls.Add(this.btn_ProductClear);
            this.Controls.Add(this.btn_ProductEdit);
            this.Controls.Add(this.btn_ProductSave);
            this.Controls.Add(this.cb_Kategorie);
            this.Controls.Add(this.tb_Preis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Marke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produkte";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ProductTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Marke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Preis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_Kategorie;
        private System.Windows.Forms.Button btn_ProductSave;
        private System.Windows.Forms.Button btn_ProductEdit;
        private System.Windows.Forms.Button btn_ProductClear;
        private System.Windows.Forms.Button btn_ProductDelete;
        private System.Windows.Forms.DataGridView dgw_ProductTable;
        private System.Windows.Forms.Button btn_BackToMainMenu;
    }
}