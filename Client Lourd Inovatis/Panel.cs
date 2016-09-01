using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Npgsql;
using NpgsqlTypes;
using MySql;
using MySql.Data.MySqlClient;


namespace Client_Lourd_Inovatis
{
    public partial class Panel : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
       
        public Panel(string Login_text = null, string Mdp_text = null)
        {
            InitializeComponent();
            if (Login_text != null && Mdp_text != null)
            {
            string login = Login_text.ToString();
            string password = Mdp_text.ToString();
            //Panel_Load_Data(login, password);
            }
            
        }
        
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Password=;Database=inovatis;");

        public void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error :S" + exp);
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

        /*protected void Panel_Load_Data(string login,string password)
        {
            conn.Open();

            MySqlCommand recup_id_user_query = new MySqlCommand("SELECT id FROM login WHERE email = '" + login + "'",conn);

            MySqlDataReader recup_id_user = recup_id_user_query.ExecuteReader();

            recup_id_user.Read();

            string id_a_convertir = recup_id_user["id_login"].ToString();

            int id_current_user = Convert.ToInt32(id_a_convertir);

            recup_id_user.Close();

            MySqlCommand recup_droit_query = new MySqlCommand ("SELECT isadmin_user FROM user WHERE id_user = '"+ id_current_user + "'",conn);

            MySqlDataReader recup_droit = recup_droit_query.ExecuteReader();

            recup_droit.Read();

            int curr_user_is_admin = Convert.ToInt32(recup_droit["isadmin_user"]);

            recup_droit.Close();

            if(curr_user_is_admin == 1)
            {
                MessageBox.Show("Connexion reussie avec les infos de connexion : " + login + " " + password, "Connecté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("Droit d'administration accordé de l'admin n° : " + curr_user_is_admin, "Admin détecté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Show();                
            } else {
                MessageBox.Show("Connexion echouée avec les infos de connexion : " + login + " " + password, "Connecté", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Droit d'administration refusé de car les informations fournies ne sont pas celles d'un administrateur", "Admin non détecté",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
                Connexion deconnexion = new Connexion();
                deconnexion.Show();
            }
           
            conn.Close();
        }*/
       
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

        private void VoirStock_Click(object sender, EventArgs e)
        {
            conn.Open();

            string sql = "SELECT `id`,`category_id`,`name`,`desc`,`quantity`,`prix` FROM `item` WHERE 1";
            
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
            
            ds.Reset();
            
            da.Fill(ds);
            
            dt = ds.Tables[0];
            
            dataGridView1.DataSource = dt;
           
            conn.Close();
        }
        private void Categories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();

            categories.Show();

            conn.Open();

            MySqlCommand query = new MySqlCommand("SELECT `name` FROM category", conn);

            MySqlDataReader query_exe = query.ExecuteReader();

            while (query_exe.Read())
            {
               categories.Categories_list.Items.Add(query_exe["name"]);
            }

            conn.Close();

            this.Hide();
        }

        private void Entree_Click(object sender, EventArgs e)
        {                   
         
           Entrée entrer = new Entrée();

           entrer.Show();
           
           conn.Open();
            // Ajouter ORDER BY ASC sur la clé primaire
            MySqlCommand query = new MySqlCommand("SELECT id,`name` FROM item ORDER BY id ASC", conn);

            MySqlDataReader query_exe = query.ExecuteReader();
            entrer.Liste_produits.Items.Add("Choisir un produit");

            while (query_exe.Read())
            {
                entrer.Liste_produits.Items.Add(query_exe["name"]);
            }
            
           conn.Close();

           this.Hide();
        }

        private void Promo_click(object sender, EventArgs e)
        {
            Promotion promo = new Promotion();
            promo.Show();

            conn.Open();

            MySqlCommand query = new MySqlCommand("SELECT `name` FROM item", conn);

            MySqlDataReader query_exe = query.ExecuteReader();

            while (query_exe.Read())
            {
               promo.liste_produit_promo.Items.Add(query_exe["name"]);
            }

            query_exe.Close();

            MySqlCommand query2 = new MySqlCommand("SELECT `id`,`date_debut`,`date_fin` FROM promo", conn);

            MySqlDataReader query_exe2 = query2.ExecuteReader();

            while (query_exe2.Read())
            {
                promo.Liste_promo.Items.Add("promo n° : "+ query_exe2["id"] + " du " + query_exe2["date_debut"] + "jusqu'au : "+ query_exe2["date_fin"] +"");
            }

            conn.Close();
            this.Hide();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Connexion deconnexion = new Connexion();
            deconnexion.Show();
        }

        
    }
}
