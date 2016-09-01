using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using MySql;
using MySql.Data.MySqlClient;

namespace Client_Lourd_Inovatis
{
    public partial class Entrée : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Password=;Database=inovatis;");

        public Entrée() 
        {
            InitializeComponent();
            /*conn.Open();

            MySqlCommand query = new MySqlCommand("SELECT name_item FROM item", conn);

            MySqlDataReader donnes = query.ExecuteReader();

            Liste_produits.Items.Clear();

            while (donnes.Read())
            {

                Liste_produits.Items.Add(donnes["name_item"]);
            }

            conn.Close();*/
        }
         
        public void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S");
            }
        }

        public void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error :S");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Voulez vous quitter l'application et vous déconnecter", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Process[] processes = Process.GetProcessesByName("Client Lourd Inovatis");
                    foreach (Process process in processes)
                    {
                        process.Kill();
                    }
                    break;
            }
        }
        private void Annuler_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Hide();
        }

        private void Actualisation_produit_Click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand query = new MySqlCommand("SELECT name FROM item", conn);

            MySqlDataReader donnes = query.ExecuteReader();

            Liste_produits.Items.Clear();
            Liste_produits.Items.Add("Choisir un produit");

            while (donnes.Read())
            {
                Liste_produits.Items.Add(donnes["name"]);
            }

            conn.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            conn.Open();
            // SelectedIndex c'est mieux pour la requete sql 
            if (Liste_produits.SelectedIndex == -1)
            {
                // User case : L'utilisateur n'a pas choisi de produit
                MessageBox.Show("Vous n'avez pas choisi de produit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (Liste_produits.SelectedIndex == 0) {
                // User case : L'utilisateur a choisi et validé l'intitulé
                MessageBox.Show("Vous n'avez pas choisi de produit mais l'intitulé de la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {

                int produits_choix = Liste_produits.SelectedIndex;

                MySqlCommand produits_exist = new MySqlCommand("SELECT id, name FROM item WHERE id = '" + produits_choix + "'", conn);

                MySqlDataReader response_produits_exist = produits_exist.ExecuteReader();

                if (response_produits_exist.HasRows && quantite.Text != "")
                {
                    response_produits_exist.Read();

                    long Quantite = 0;

                    long.TryParse(quantite.Text, out Quantite);

                    if (Quantite < 0)
                    {  
                        // User case : L'utilisateur n'a pas saisi de quantité
                        MessageBox.Show("Quantité saisie incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else {

                        MySqlCommand query_update = new MySqlCommand("UPDATE item SET quantity = " + Quantite + " WHERE id = " + response_produits_exist["id"] + "", conn);

                        response_produits_exist.Close();

                        MySqlDataReader response_query_update = query_update.ExecuteReader();

                        MessageBox.Show("Mise en stock du produit n° : " + produits_choix + " pour une quantité de : " + Quantite, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                } else if (quantite.Text == "") {
                    // User case : L'utilisateur n'a pas saisi de quantité
                    MessageBox.Show("Quantité saisie incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                   // User case : L'utilisateur a choisi qui a été supprimé 
                    MessageBox.Show("Le produit n'existe plus veuillez actualiser la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            
            conn.Close();
        }
    }
}
