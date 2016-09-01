using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using ObjectDumper;

namespace Client_Lourd_Inovatis
{
    public partial class Categories : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Password=;Database=inovatis;");
        public Categories()
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

        private void Valider_Click(object sender, EventArgs e)
        {
            
            string categorie_a_ajoutée = New_categories_text.Text;

            if (categorie_a_ajoutée == null || categorie_a_ajoutée == "")
            {
                MessageBox.Show("Vous n'avez pas saisi de nouvelle categorie", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                conn.Open();

                string categorie_ajoutée = categorie_a_ajoutée.ToString();

                MySqlCommand verif_new_categorie_query = new MySqlCommand("SELECT name FROM category WHERE name = '" + categorie_ajoutée + "'", conn);

                MySqlDataReader verif_new_categorie = verif_new_categorie_query.ExecuteReader();

                if (!verif_new_categorie.HasRows)
                {
                    //ObjectDumperExtensions.DumpToString(verif_new_categorie, "categorie existe deja");
                   
                    verif_new_categorie.Close();

                    MySqlCommand ajouter_new_categorie_query = new MySqlCommand("INSERT INTO category (name) VALUES ('"+ categorie_ajoutée +"')", conn);

                    MySqlDataReader ajouter_new_categorie = ajouter_new_categorie_query.ExecuteReader();

                    MessageBox.Show("Nouvelle catégorie ajoutée au nom de : " + categorie_ajoutée, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ajouter_new_categorie_query.Clone();

                    conn.Close();
                } else {
                    MessageBox.Show("La categorie existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    verif_new_categorie.Close();
                   
                    conn.Close();
                }

            }
        }

    
        private void Supprimer_Click(object sender, EventArgs e)
        {
            conn.Open();

            string choix_categorie = "";

            if(Categories_list.SelectedItem == null)
            {
                MessageBox.Show("Vous n'avez pas choisi de categories", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                choix_categorie = Categories_list.SelectedItem.ToString();

                // Passer la clé étrangère de la catégorie dans la table produits a NULL avant de supprimer la catégorie
                MySqlCommand retrieve_id_categorie_query = new MySqlCommand("SELECT id FROM category WHERE name = '" + choix_categorie + "'", conn);

                MySqlDataReader id_categorie_supp = retrieve_id_categorie_query.ExecuteReader();

                id_categorie_supp.Read();

                string id_categorie_produit_supp_string = id_categorie_supp["id"].ToString();

                int id_categorie_produit_supp = Convert.ToInt32(id_categorie_produit_supp_string);

                id_categorie_supp.Close();

                MySqlCommand fk_item_categorie1_query = new MySqlCommand("UPDATE item SET categorie_id = null WHERE categorie_id =" + id_categorie_produit_supp,conn);

                MySqlDataReader fk_item_categorie1_to_null = fk_item_categorie1_query.ExecuteReader();

                fk_item_categorie1_to_null.Close();

                // Suppression de la catégorie
                MySqlCommand categories_exist_query = new MySqlCommand("DELETE FROM category WHERE name = '" + choix_categorie + "'", conn);

                MySqlDataReader supprimer_categorie = categories_exist_query.ExecuteReader();

                supprimer_categorie.Close();

                MessageBox.Show("Categorie supprimé avec succes","Succes",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            conn.Close();
        }

        private void Actualiser_click(object sender, EventArgs e)
        {
            conn.Open();

            MySqlCommand query = new MySqlCommand("SELECT name FROM category", conn);

            MySqlDataReader donnes = query.ExecuteReader();

            Categories_list.Items.Clear();

            while (donnes.Read())
            {
                Categories_list.Items.Add(donnes["name"]);
            }

            conn.Close();
        }
    }
}
