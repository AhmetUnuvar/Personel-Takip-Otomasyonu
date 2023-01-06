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
    public partial class GirisForm : Form
    {
        BaglantiSinif bgl = new BaglantiSinif();
        public GirisForm()
        {
            InitializeComponent();
        }



        private void BtnGirisAdmin_Click(object sender, EventArgs e)    
        {
            
        }

        private void btngirispanelkayitol_Click(object sender, EventArgs e)
        {
            
            
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void kullaniciAdiText_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void admingirisbtn_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            Anasayfa ana = new Anasayfa();
            this.Hide();
            
            try
            {
                baglan.Open();
                string sql = "Select * From kullaniciAdiSifre where KullaniciAdi=@adi AND Sifre=@sifresi ";
                SqlParameter prm1 = new SqlParameter("adi", buntxtgiriskullanıcı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifresi", bunifuTextBoxsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglan);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Anasayfa anasayfa = new Anasayfa();
                    anasayfa.Show();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            GirisForm giris = new GirisForm();
            giris.Close();
            this.Hide();
        
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            giristarihsaat.Text = DateTime.Now.ToLongDateString();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
