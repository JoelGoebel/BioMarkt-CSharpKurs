namespace ProNaturBiomarkt
{
    partial class MainMenuScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuScreen));
            this.btn_Products = new System.Windows.Forms.Button();
            this.btn_Rechnung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Products
            // 
            resources.ApplyResources(this.btn_Products, "btn_Products");
            this.btn_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Products.ForeColor = System.Drawing.Color.White;
            this.btn_Products.Name = "btn_Products";
            this.btn_Products.UseVisualStyleBackColor = true;
            this.btn_Products.Click += new System.EventHandler(this.btn_Products_Click);
            // 
            // btn_Rechnung
            // 
            resources.ApplyResources(this.btn_Rechnung, "btn_Rechnung");
            this.btn_Rechnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rechnung.ForeColor = System.Drawing.Color.White;
            this.btn_Rechnung.Name = "btn_Rechnung";
            this.btn_Rechnung.UseVisualStyleBackColor = true;
            this.btn_Rechnung.Click += new System.EventHandler(this.btn_Rechnung_Click);
            // 
            // MainMenuScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btn_Rechnung);
            this.Controls.Add(this.btn_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Products;
        private System.Windows.Forms.Button btn_Rechnung;
    }
}