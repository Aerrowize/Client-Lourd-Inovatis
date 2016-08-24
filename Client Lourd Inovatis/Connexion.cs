using System;
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
using System.Data.SqlClient;
using ObjectDumper;

namespace Client_Lourd_Inovatis
{
    
    public partial class Connexion : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Database=inovatis_ecommerce;");
        public Connexion()
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

        private void Connexion_bouton_Click(object sender, EventArgs e)
        {
          
            if (Login_text.Text != "" && Mdp_text.Text != "")
            {

            conn.Open();

            MySqlCommand login = new MySqlCommand("SELECT * FROM login WHERE email_login = '" + Login_text.Text + "' AND password_login = '" + Mdp_text.Text + "'", conn);

            MySqlDataReader response_login = login.ExecuteReader();

                if (response_login.HasRows && response_login.Read())
                {
                    conn.Close();
                    Panel panel = new Panel(Login_text.Text, Mdp_text.Text);
                    this.Hide();
                } else {
                    conn.Close();
                    MessageBox.Show("Erreur Login/Password", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                }

                } else {
                conn.Close();
                MessageBox.Show("Login/Password non renseignés", "Echec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
          
        }
    }
}
