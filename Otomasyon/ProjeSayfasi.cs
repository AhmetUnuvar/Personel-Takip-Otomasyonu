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
    public partial class ProjeSayfasi : Form
    {
        
        public ProjeSayfasi()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        public void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("Select * from projeTakip",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridProje.DataSource = dt;
        }

        private void ProjeSayfasi_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            // TODO: Bu kod satırı 'calisanTakipSistemiDataSet4.projeTakip' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            listele();
        }

       
        int secilen;

        private void datagridProje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, ad, soyad, projeadı, gorev;
            secilen = datagridProje.SelectedCells[0].RowIndex;
            id = datagridProje.Rows[secilen].Cells[0].Value.ToString();
            ad = datagridProje.Rows[secilen].Cells[1].Value.ToString();
            soyad = datagridProje.Rows[secilen].Cells[2].Value.ToString();
            projeadı = datagridProje.Rows[secilen].Cells[3].Value.ToString();
            gorev = datagridProje.Rows[secilen].Cells[4].Value.ToString();

            personelIDProjetxt.Text = id;
            personeladProjetxt.Text = ad;
            personelSoyadProjetxt.Text = soyad;
            projeAdiprojetxt.Text = projeadı;
            personelGorevProjetxt.Text = gorev;
        }

        

        private void btnProjeEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into projeTakip (PersonelID,PersonelAdi,PersonelSoyadi,ProjeAdi,ProjedekiGorevi) values (@id,@adi,@soyadi,@projeadi,@gorev)", baglan);
            komut.Parameters.AddWithValue("@id", personelIDProjetxt.Text);
            komut.Parameters.AddWithValue("@adi", personeladProjetxt.Text);
            komut.Parameters.AddWithValue("@soyadi", personelSoyadProjetxt.Text);
            komut.Parameters.AddWithValue("@projeadi", projeAdiprojetxt.Text);
            komut.Parameters.AddWithValue("@gorev", personelGorevProjetxt.Text);
            komut.ExecuteNonQuery();
            listele();
            MessageBox.Show("Başarılı Bir Şekilde Eklendi");
            baglan.Close();
        }

       

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from projeTakip where PersonelID=@P1", baglan);
            komut.Parameters.AddWithValue("@P1", personelIDProjetxt.Text);
            komut.ExecuteNonQuery();
            listele();
            MessageBox.Show("Silme İşlemi Başarılı");
            baglan.Close();

        }

       

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("update projeTakip set PersonelAdi='" + personeladProjetxt.Text + "',PersonelSoyadi='" + personelSoyadProjetxt.Text + "',ProjeAdi='" + projeAdiprojetxt.Text + "',ProjedekiGorevi='" + personelGorevProjetxt.Text + "' where PersonelID='" + personelIDProjetxt.Text + "'", baglan);
            komut.ExecuteNonQuery();
            listele();
            MessageBox.Show("Başarılı Bir Şekilde Güncellendi");

            baglan.Close();
        }

       

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            personelIDProjetxt.Text = " ";
            personeladProjetxt.Text = " ";
            personelSoyadProjetxt.Text = " ";
            projeAdiprojetxt.Text = " ";
            personelGorevProjetxt.Text = " ";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            ProjeSayfasi kapat = new ProjeSayfasi();
            kapat.Close();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Anasayfa back = new Anasayfa();
            back.Show();
            this.Hide();
        }
    }
}
