namespace Client_Lourd_Inovatis
{
    partial class Entrée
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entrée));
            this.Ajouter = new System.Windows.Forms.Button();
            this.quantite = new System.Windows.Forms.TextBox();
            this.Annuler = new System.Windows.Forms.Button();
            this.Liste_produits = new System.Windows.Forms.ListBox();
            this.Actualisation_produit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajouter.Location = new System.Drawing.Point(565, 98);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(108, 32);
            this.Ajouter.TabIndex = 1;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // quantite
            // 
            this.quantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.quantite.Location = new System.Drawing.Point(298, 93);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(238, 22);
            this.quantite.TabIndex = 2;
            // 
            // Annuler
            // 
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(565, 191);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(108, 33);
            this.Annuler.TabIndex = 3;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Liste_produits
            // 
            this.Liste_produits.BackColor = System.Drawing.SystemColors.Window;
            this.Liste_produits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Liste_produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.Liste_produits.FormattingEnabled = true;
            this.Liste_produits.HorizontalScrollbar = true;
            this.Liste_produits.ItemHeight = 16;
            this.Liste_produits.Location = new System.Drawing.Point(13, 15);
            this.Liste_produits.Name = "Liste_produits";
            this.Liste_produits.Size = new System.Drawing.Size(261, 100);
            this.Liste_produits.TabIndex = 4;
            // 
            // Actualisation_produit
            // 
            this.Actualisation_produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualisation_produit.Location = new System.Drawing.Point(13, 130);
            this.Actualisation_produit.Name = "Actualisation_produit";
            this.Actualisation_produit.Size = new System.Drawing.Size(261, 41);
            this.Actualisation_produit.TabIndex = 5;
            this.Actualisation_produit.Text = "Actualisation";
            this.Actualisation_produit.UseVisualStyleBackColor = true;
            this.Actualisation_produit.Click += new System.EventHandler(this.Actualisation_produit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantité";
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(Client_Lourd_Inovatis.Program);
            // 
            // Entrée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 236);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualisation_produit);
            this.Controls.Add(this.Liste_produits);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.quantite);
            this.Controls.Add(this.Ajouter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 275);
            this.MinimumSize = new System.Drawing.Size(720, 275);
            this.Name = "Entrée";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iNovatis - Entrée";
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Actualisation_produit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource programBindingSource;
        protected internal System.Windows.Forms.ListBox Liste_produits;
    }
}