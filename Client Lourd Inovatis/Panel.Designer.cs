namespace Client_Lourd_Inovatis
{
    partial class Panel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Suivi_Livraison = new System.Windows.Forms.Button();
            this.Entree = new System.Windows.Forms.Button();
            this.VoirStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Commande_produits = new System.Windows.Forms.Button();
            this.Categories = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Promotions = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Bons_de_commande = new System.Windows.Forms.Button();
            this.Devis = new System.Windows.Forms.Button();
            this.Factures = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Chercher = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Suivi_Livraison);
            this.groupBox1.Controls.Add(this.Entree);
            this.groupBox1.Controls.Add(this.VoirStock);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(13, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // Suivi_Livraison
            // 
            this.Suivi_Livraison.Location = new System.Drawing.Point(23, 97);
            this.Suivi_Livraison.Name = "Suivi_Livraison";
            this.Suivi_Livraison.Size = new System.Drawing.Size(298, 51);
            this.Suivi_Livraison.TabIndex = 3;
            this.Suivi_Livraison.Text = "Suivi Des livraisons";
            this.Suivi_Livraison.UseVisualStyleBackColor = true;
            // 
            // Entree
            // 
            this.Entree.Location = new System.Drawing.Point(190, 23);
            this.Entree.Name = "Entree";
            this.Entree.Size = new System.Drawing.Size(131, 53);
            this.Entree.TabIndex = 1;
            this.Entree.Text = "Entrée/Sortie";
            this.Entree.UseVisualStyleBackColor = true;
            this.Entree.Click += new System.EventHandler(this.Entree_Click);
            // 
            // VoirStock
            // 
            this.VoirStock.Location = new System.Drawing.Point(23, 23);
            this.VoirStock.Name = "VoirStock";
            this.VoirStock.Size = new System.Drawing.Size(139, 53);
            this.VoirStock.TabIndex = 0;
            this.VoirStock.Text = "Voir Le Stock";
            this.VoirStock.UseVisualStyleBackColor = true;
            this.VoirStock.Click += new System.EventHandler(this.VoirStock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Commande_produits);
            this.groupBox2.Controls.Add(this.Categories);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox2.Location = new System.Drawing.Point(381, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 181);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produits";
            // 
            // Commande_produits
            // 
            this.Commande_produits.Location = new System.Drawing.Point(27, 115);
            this.Commande_produits.Name = "Commande_produits";
            this.Commande_produits.Size = new System.Drawing.Size(213, 34);
            this.Commande_produits.TabIndex = 2;
            this.Commande_produits.Text = "Commander des Produits";
            this.Commande_produits.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            this.Categories.Location = new System.Drawing.Point(27, 21);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(213, 85);
            this.Categories.TabIndex = 0;
            this.Categories.Text = "Creer des Catégories";
            this.Categories.UseVisualStyleBackColor = true;
            this.Categories.Click += new System.EventHandler(this.Categories_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Promotions);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox3.Location = new System.Drawing.Point(665, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 181);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Promotions";
            // 
            // Promotions
            // 
            this.Promotions.Location = new System.Drawing.Point(7, 22);
            this.Promotions.Name = "Promotions";
            this.Promotions.Size = new System.Drawing.Size(246, 127);
            this.Promotions.TabIndex = 0;
            this.Promotions.Text = "Offres Promotionnelles";
            this.Promotions.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Bons_de_commande);
            this.groupBox4.Controls.Add(this.Devis);
            this.groupBox4.Controls.Add(this.Factures);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox4.Location = new System.Drawing.Point(946, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 181);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Facturation";
            // 
            // Bons_de_commande
            // 
            this.Bons_de_commande.Location = new System.Drawing.Point(6, 123);
            this.Bons_de_commande.Name = "Bons_de_commande";
            this.Bons_de_commande.Size = new System.Drawing.Size(388, 44);
            this.Bons_de_commande.TabIndex = 2;
            this.Bons_de_commande.Text = "Mes Bons De Commandes";
            this.Bons_de_commande.UseVisualStyleBackColor = true;
            // 
            // Devis
            // 
            this.Devis.Location = new System.Drawing.Point(6, 74);
            this.Devis.Name = "Devis";
            this.Devis.Size = new System.Drawing.Size(388, 43);
            this.Devis.TabIndex = 1;
            this.Devis.Text = "Mes Devis";
            this.Devis.UseVisualStyleBackColor = true;
            // 
            // Factures
            // 
            this.Factures.Location = new System.Drawing.Point(6, 21);
            this.Factures.Name = "Factures";
            this.Factures.Size = new System.Drawing.Size(388, 47);
            this.Factures.TabIndex = 0;
            this.Factures.Text = "Mes Factures";
            this.Factures.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Chercher);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox5.Location = new System.Drawing.Point(13, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1333, 43);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rechercher";
            // 
            // Chercher
            // 
            this.Chercher.Location = new System.Drawing.Point(1179, 14);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(148, 23);
            this.Chercher.TabIndex = 3;
            this.Chercher.Text = "Chercher";
            this.Chercher.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(549, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(607, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Libéllé";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Référence";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1333, 371);
            this.dataGridView1.TabIndex = 7;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1364, 652);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1380, 691);
            this.MinimumSize = new System.Drawing.Size(1380, 691);
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iNovatis - Gestion Stock";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Suivi_Livraison;
        private System.Windows.Forms.Button Entree;
        private System.Windows.Forms.Button VoirStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Commande_produits;
        private System.Windows.Forms.Button Categories;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Promotions;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Bons_de_commande;
        private System.Windows.Forms.Button Devis;
        private System.Windows.Forms.Button Factures;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Chercher;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
    }
}

