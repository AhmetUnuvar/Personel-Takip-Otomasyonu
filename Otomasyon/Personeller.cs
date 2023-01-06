using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Otomasyon
{
    public partial class Personeller : Form
    {
       
        public Personeller()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        public void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("Select * from calisanBilgileri", baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridPersoneller.DataSource = dt;
        }
        private void Personeller_Load(object sender, EventArgs e)
        {
            listele();
            
        }
    }
}
