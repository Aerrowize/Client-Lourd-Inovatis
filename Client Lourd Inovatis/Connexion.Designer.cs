namespace Client_Lourd_Inovatis
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.Login_text = new System.Windows.Forms.TextBox();
            this.Mdp_text = new System.Windows.Forms.TextBox();
            this.Connexion_bouton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_text
            // 
            this.Login_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_text.Location = new System.Drawing.Point(108, 79);
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(202, 22);
            this.Login_text.TabIndex = 0;
            // 
            // Mdp_text
            // 
            this.Mdp_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mdp_text.Location = new System.Drawing.Point(108, 105);
            this.Mdp_text.Name = "Mdp_text";
            this.Mdp_text.PasswordChar = '*';
            this.Mdp_text.Size = new System.Drawing.Size(202, 22);
            this.Mdp_text.TabIndex = 1;
            this.Mdp_text.UseSystemPasswordChar = true;
            // 
            // Connexion_bouton
            // 
            this.Connexion_bouton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connexion_bouton.Location = new System.Drawing.Point(110, 155);
            this.Connexion_bouton.Name = "Connexion_bouton";
            this.Connexion_bouton.Size = new System.Drawing.Size(140, 27);
            this.Connexion_bouton.TabIndex = 2;
            this.Connexion_bouton.Text = "Connexion";
            this.Connexion_bouton.UseVisualStyleBackColor = true;
            this.Connexion_bouton.Click += new System.EventHandler(this.Connexion_bouton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connexion";
            // 
            // Connexion
            // 
            this.AcceptButton = this.Connexion_bouton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 211);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connexion_bouton);
            this.Controls.Add(this.Mdp_text);
            this.Controls.Add(this.Login_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 250);
            this.MinimumSize = new System.Drawing.Size(385, 250);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.TextBox Mdp_text;
        private System.Windows.Forms.Button Connexion_bouton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}