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
    public partial class MaaşBilgileri : Form
    {
       
        //SQL Bağlantısı
        public MaaşBilgileri()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        public void listele()
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("Select * from personelMaasTakip",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridmaas.DataSource = dt;

        }

        private void MaaşBilgileri_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            listele();
        }


        int secilen;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, ad, soyad, gorev,maas;
           
            secilen = datagridmaas.SelectedCells[0].RowIndex;
            id = datagridmaas.Rows[secilen].Cells[0].Value.ToString();
            ad = datagridmaas.Rows[secilen].Cells[1].Value.ToString();
            soyad = datagridmaas.Rows[secilen].Cells[2].Value.ToString();
            gorev = datagridmaas.Rows[secilen].Cells[3].Value.ToString();
            maas = datagridmaas.Rows[secilen].Cells[4].Value.ToString();

            maasIDtext.Text = id;
            maasAdiText.Text = ad;
            maasSoyadi.Text = soyad;
            maasGoreviText.Text = gorev;
            maasMaastext.Text = maas;

        }

        private void btnPersEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {

                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into personelMaasTakip (PersonelID,PersonelAdi,PersonelSoyadi,PersonelMevki,PersonelMaas) values (@id,@adi,@soyadi,@mevkisi,@maasi)", baglan);
                komut.Parameters.AddWithValue("@id", maasIDtext.Text);
                komut.Parameters.AddWithValue("@adi", maasAdiText.Text);
                komut.Parameters.AddWithValue("@soyadi", maasSoyadi.Text);
                komut.Parameters.AddWithValue("@mevkisi", maasGoreviText.Text);
                komut.Parameters.AddWithValue("@maasi", maasMaastext.Text);
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Başarılı Bir Şekilde Eklendi");
                
                
                baglan.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Başarısız");
            }
        }
        private void btnMaasDelete_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Delete from personelMaasTakip where PersonelID=@P1", baglan);
                komut.Parameters.AddWithValue("@P1", maasIDtext.Text);
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Silme İşlemi Başarılı");
               
                baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Silme İşlemi Gerçekleştirilemedi");

            }
        }

        private void btnPersGuncel_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("update personelMaasTakip set PersonelAdi='" + maasAdiText.Text + "',PersonelSoyadi='" + maasSoyadi.Text + "',PersonelMevki='" + maasGoreviText.Text + "',PersonelMaas='" + maasMaastext.Text + "' where PersonelID='" + maasIDtext.Text + "'", baglan);
                komut.ExecuteNonQuery();
                listele();

                baglan.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Güncelleme İşlemi Başarısız.");

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            maasIDtext.Text = " ";
            maasAdiText.Text = " ";
            maasSoyadi.Text = " ";
            maasGoreviText.Text = " ";
            maasMaastext.Text = " ";
        }

        private void btnPersAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from personelMaasTakip where PersonelAdi like '%" + txtArama.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            datagridmaas.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MaaşBilgileri maas =new MaaşBilgileri();
            maas.Close();
            this.Hide();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Anasayfa back = new Anasayfa();
            back.Show();
            this.Hide();
        }
    }
            
        }

       
        
    

