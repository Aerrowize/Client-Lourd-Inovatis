using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectDumper;

namespace Client_Lourd_Inovatis
{
    public partial class Promotion : Form
    {
        public Promotion()
        {
            InitializeComponent();
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            panel.Show();
            this.Hide();
        }

        private void Ajouter_promo_Click(object sender, EventArgs e)
        {
            DateTime date_de_debut_promo = date_fin_promo.Value;
            
            DateTime date_de_fin_promo = date_fin_promo.Value;


        }
    }
}
