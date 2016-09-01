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
using System.Security.Cryptography;

namespace Client_Lourd_Inovatis
{
    
    public partial class Connexion : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Port=3306;UID=root;Database=inovatis;");
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

                MySqlCommand login = new MySqlCommand("SELECT username,salt,password FROM user WHERE username = '" + Login_text.Text + "'", conn);

                MySqlDataReader response_login = login.ExecuteReader();

                if (response_login.Read() && response_login.HasRows)
                {
                    // Le sel 
                    string sel = Convert.ToString(response_login["salt"]);
                    // Le mot de passe saisie
                    string password = Mdp_text.Text;
                    // Le mot passe crypté en base
                    string password_bdd_md5 = Convert.ToString(response_login["password"]);

                    string pass_a_hasher = password + sel;

                    StringBuilder hash = new StringBuilder();

                    MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();

                    byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(pass_a_hasher));

                    for (int i = 0; i < bytes.Length; i++)
                    {
                        hash.Append(bytes[i].ToString("x2"));
                    }

                    string pass_a_comparer = Convert.ToString(hash.ToString());

                    if (password_bdd_md5 == pass_a_comparer)
                        conn.Close();
                        MessageBox.Show("Connexion reussie", "Connecté", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Panel panel = new Panel();
                        panel.Show();
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
                conn.Close();
            }          
        }
    }
