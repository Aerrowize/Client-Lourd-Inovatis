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
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Password=;Database=inovatis_ecommerce;");

        public Entrée() 
        {
            InitializeComponent();
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

            MySqlCommand query = new MySqlCommand("SELECT name_item FROM item", conn);

            MySqlDataReader donnes = query.ExecuteReader();

            Liste_produits.Items.Clear();

            while (donnes.Read())
            {
                Liste_produits.Items.Add(donnes["name_item"]);
            }

            conn.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            conn.Open();

            string produits_choix = "";

            if (Liste_produits.SelectedItem == null)
            {
                MessageBox.Show("Vous n'avez pas choisi de produit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {
                    
                produits_choix = Liste_produits.SelectedItem.ToString();

                MySqlCommand produits_exist = new MySqlCommand("SELECT id_item, name_item FROM item WHERE name_item = '" + produits_choix + "'", conn);

                MySqlDataReader response_produits_exist = produits_exist.ExecuteReader();

                if (response_produits_exist.HasRows) 
                {
                    response_produits_exist.Read();

                    long Quantite = 0;

                    long.TryParse(quantite.Text, out Quantite);

                    if (Quantite == 0)
                    {
                        MessageBox.Show("Quantité saisie nulle", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    } else {

                        MySqlCommand query_update = new MySqlCommand("UPDATE item SET quantity_item = " + Quantite + " WHERE id_item = " + response_produits_exist["id_item"] + "", conn);

                        response_produits_exist.Close();

                        MySqlDataReader response_query_update = query_update.ExecuteReader();

                        MessageBox.Show("Mise en stock du produit : " + produits_choix + " pour une quantité de : " + Quantite, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                 } else {
                    MessageBox.Show("Le produit n'existe plus veuillez actualiser la liste", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            conn.Close();
        }
    }
}
