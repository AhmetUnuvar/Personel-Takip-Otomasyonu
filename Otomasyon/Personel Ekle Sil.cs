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
    
    public partial class PersonelEkleSil : Form
    {
        
        public PersonelEkleSil()
        {
            InitializeComponent();
        }
        BaglantiSinif bgl = new BaglantiSinif();

        public void listele() {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("Select * from calisanBilgileri",baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagridpersoneleklecikar.DataSource = dt;

        }
        private void PersonelEkleSil_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            // TODO: Bu kod satırı 'calisanTakipSistemiDataSet5.calisanBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            listele();
        }
   
        private void datagridpersoneleklecikar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seciliAlan = datagridpersoneleklecikar.SelectedCells[0].RowIndex;

            string id = datagridpersoneleklecikar.Rows[seciliAlan].Cells[0].Value.ToString();
            string tc = datagridpersoneleklecikar.Rows[seciliAlan].Cells[1].Value.ToString();
            string ad = datagridpersoneleklecikar.Rows[seciliAlan].Cells[2].Value.ToString();
            string soyad = datagridpersoneleklecikar.Rows[seciliAlan].Cells[3].Value.ToString();
            string gorev = datagridpersoneleklecikar.Rows[seciliAlan].Cells[4].Value.ToString();
            string cinsiyet = datagridpersoneleklecikar.Rows[seciliAlan].Cells[5].Value.ToString();
            string uyruk = datagridpersoneleklecikar.Rows[seciliAlan].Cells[6].Value.ToString();
            string dogum = datagridpersoneleklecikar.Rows[seciliAlan].Cells[7].Value.ToString();

            personelekletxtıd.Text = id;
            tctextpersonelinfo.Text = tc;
            personeladtextinfo.Text = ad;
            personelsoyadtextinfo.Text = soyad;
            personelgorevtext.Text = gorev;
            personelinfocinstext.Text = cinsiyet;
            personeluyruktextinfo.Text = uyruk;
            personeldogumtextinfo.Text = dogum;

        }

        private void btnPersEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Insert into calisanBilgileri (TCKimlikNo,Adi,Soyadi,Gorevi,Cinsiyeti,Uyrugu,DogumTarihi) values (@tc,@ad,@soyad,@gorev,@cinsiyet,@uyruk,@dogum)", baglan);

                komut.Parameters.AddWithValue("@tc", tctextpersonelinfo.Text);
                komut.Parameters.AddWithValue("@ad", personeladtextinfo.Text);
                komut.Parameters.AddWithValue("@soyad", personelsoyadtextinfo.Text);
                komut.Parameters.AddWithValue("@gorev", personelgorevtext.Text);
                komut.Parameters.AddWithValue("@cinsiyet", personelinfocinstext.Text);
                komut.Parameters.AddWithValue("@uyruk", personeluyruktextinfo.Text);
                komut.Parameters.AddWithValue("@dogum", personeldogumtextinfo.Text);
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Ekleme İşlemi Başarılı");

                baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme İşlemi Başarısız");

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Delete from calisanBilgileri where ID=@P1", baglan);
                komut.Parameters.AddWithValue("@P1", personelekletxtıd.Text);
                komut.ExecuteNonQuery();
                listele();
                MessageBox.Show("Silme İşlemi Başarılı");
                baglan.Close();



            }
            catch (Exception)
            {

                MessageBox.Show("Silme İşlemi Başarısız");
            }
           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            personelekletxtıd.Text = " ";
            tctextpersonelinfo.Text = " ";
            personeladtextinfo.Text = " ";
            personelsoyadtextinfo.Text = " ";
            personelgorevtext.Text = " ";
            personelinfocinstext.Text = " ";
            personeluyruktextinfo.Text = " ";
            personeldogumtextinfo.Text = " ";
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(bgl.Adres);
            try
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Update calisanBilgileri Set TCKimlikNo=@p1,Adi=@p2,Soyadi=@p3,Gorevi=@p4,Cinsiyeti=@p5,Uyrugu=@p6,DogumTarihi=@p7 where ID=@p8", baglan);
                komut.Parameters.AddWithValue("p1", tctextpersonelinfo.Text);
                komut.Parameters.AddWithValue("p2", personeladtextinfo.Text);
                komut.Parameters.AddWithValue("p3", personelsoyadtextinfo.Text);
                komut.Parameters.AddWithValue("p4", personelgorevtext.Text);
                komut.Parameters.AddWithValue("p5", personelinfocinstext.Text);
                komut.Parameters.AddWithValue("p6", personeluyruktextinfo.Text);
                komut.Parameters.AddWithValue("p7", personeldogumtextinfo.Text);
                komut.Parameters.AddWithValue("p8", personelekletxtıd.Text);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
                listele();

            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme İşlemi Başarısız");

            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            PersonelEkleSil close = new PersonelEkleSil();
            close.Close();
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


