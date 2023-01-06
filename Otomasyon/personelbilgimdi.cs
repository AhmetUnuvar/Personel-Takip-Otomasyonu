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
    public partial class personelbilgimdi : Form
    {
        public personelbilgimdi()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q7UNJV9\\SQLEXPRESS;Initial Catalog=CalisanTakipSistemi;Integrated Security=True");
        public void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from calisanBilgiler",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridcontrolpersonelinfo.DataSource = dt;

        }
        private void personelbilgimdi_Load(object sender, EventArgs e)
        {
            listele();

        }
    }
}
