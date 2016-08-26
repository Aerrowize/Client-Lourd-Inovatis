namespace Client_Lourd_Inovatis
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.Categories_list = new System.Windows.Forms.ListBox();
            this.Categories_label = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.New_categories_text = new System.Windows.Forms.TextBox();
            this.New_categorie_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Categories_list
            // 
            this.Categories_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_list.FormattingEnabled = true;
            this.Categories_list.ItemHeight = 16;
            this.Categories_list.Location = new System.Drawing.Point(412, 53);
            this.Categories_list.Name = "Categories_list";
            this.Categories_list.Size = new System.Drawing.Size(260, 132);
            this.Categories_list.TabIndex = 0;
            // 
            // Categories_label
            // 
            this.Categories_label.AutoSize = true;
            this.Categories_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categories_label.Location = new System.Drawing.Point(409, 23);
            this.Categories_label.Name = "Categories_label";
            this.Categories_label.Size = new System.Drawing.Size(137, 16);
            this.Categories_label.TabIndex = 1;
            this.Categories_label.Text = "Catégories existantes";
            // 
            // Annuler
            // 
            this.Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Annuler.Location = new System.Drawing.Point(477, 335);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(260, 31);
            this.Annuler.TabIndex = 2;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Valider
            // 
            this.Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valider.Location = new System.Drawing.Point(15, 80);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(260, 32);
            this.Valider.TabIndex = 3;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // New_categories_text
            // 
            this.New_categories_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_categories_text.Location = new System.Drawing.Point(15, 53);
            this.New_categories_text.Name = "New_categories_text";
            this.New_categories_text.Size = new System.Drawing.Size(259, 21);
            this.New_categories_text.TabIndex = 4;
            // 
            // New_categorie_label
            // 
            this.New_categorie_label.AutoSize = true;
            this.New_categorie_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_categorie_label.Location = new System.Drawing.Point(12, 23);
            this.New_categorie_label.Name = "New_categorie_label";
            this.New_categorie_label.Size = new System.Drawing.Size(156, 16);
            this.New_categorie_label.TabIndex = 5;
            this.New_categorie_label.Text = "Saisir nouvelle categorie";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(412, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Supprimer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Actualiser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Actualiser_click);
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.New_categorie_label);
            this.Controls.Add(this.New_categories_text);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Categories_label);
            this.Controls.Add(this.Categories_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Categories";
            this.Text = "Categories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Categories_label;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox New_categories_text;
        private System.Windows.Forms.Label New_categorie_label;
        protected internal System.Windows.Forms.ListBox Categories_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}