namespace Client_Lourd_Inovatis
{
    partial class Promotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Promotion));
            this.date_fin_promo = new System.Windows.Forms.DateTimePicker();
            this.date_debut_promo = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.liste_produit_promo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste_promo = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_fin_promo
            // 
            this.date_fin_promo.Location = new System.Drawing.Point(451, 115);
            this.date_fin_promo.Name = "date_fin_promo";
            this.date_fin_promo.Size = new System.Drawing.Size(200, 20);
            this.date_fin_promo.TabIndex = 0;
            // 
            // date_debut_promo
            // 
            this.date_debut_promo.Location = new System.Drawing.Point(451, 35);
            this.date_debut_promo.Name = "date_debut_promo";
            this.date_debut_promo.Size = new System.Drawing.Size(200, 20);
            this.date_debut_promo.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(561, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 30);
            this.button3.TabIndex = 4;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // liste_produit_promo
            // 
            this.liste_produit_promo.FormattingEnabled = true;
            this.liste_produit_promo.Location = new System.Drawing.Point(12, 35);
            this.liste_produit_promo.Name = "liste_produit_promo";
            this.liste_produit_promo.Size = new System.Drawing.Size(222, 95);
            this.liste_produit_promo.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(451, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter la promotion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Ajouter_promo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date de debut de la promotion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date de fin de de la promotion";
            // 
            // Liste_promo
            // 
            this.Liste_promo.FormattingEnabled = true;
            this.Liste_promo.Location = new System.Drawing.Point(12, 261);
            this.Liste_promo.Name = "Liste_promo";
            this.Liste_promo.Size = new System.Drawing.Size(222, 95);
            this.Liste_promo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Liste des produits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Liste des promotion en cours";
            // 
            // Promotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Liste_promo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.liste_produit_promo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.date_debut_promo);
            this.Controls.Add(this.date_fin_promo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Promotion";
            this.Text = "Promotion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_fin_promo;
        private System.Windows.Forms.DateTimePicker date_debut_promo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ListBox liste_produit_promo;
        public System.Windows.Forms.ListBox Liste_promo;
    }
}