using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AdresDefteri.Models;

namespace AdresDefteri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Kisi kisi = new Kisi();
        Ders ders = new Ders();

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //try
            //{
            //    kisi.Ad = "Kamil";
            //    kisi.Soyad = "³Fýdýl";
            //    kisi.DogumTarihi = new DateTime(1985, 5, 20);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Bir hata oluþtu: {ex.Message}");
            //} // set
            //MessageBox.Show($"Kiþinin yaþý: {kisi.Yas}"); //get
        }

        private List<Kisi> kisiler = new List<Kisi>();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dtpDogumTarihi.Value;
                yeniKisi.Tckn = txtTCKN.Text;

                kisiler.Add(yeniKisi);
                //lstKisiler.Items.Add(yeniKisi.ToString());
                ListeyiDoldur();

                //yeniKisi.OlusturulmaZamani= DateTime.Now.AddDays(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bir Hata Oluþtu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListeyiDoldur()
        {
            lstKisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                lstKisiler.Items.Add(kisi1);
            }
        }

        private Kisi seciliKisi;
        private void lstKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKisiler.SelectedItem == null) return;

            seciliKisi = lstKisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTCKN.Text = seciliKisi.Tckn;
            dtpDogumTarihi.Value = seciliKisi.DogumTarihi;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.DogumTarihi = dtpDogumTarihi.Value;
            seciliKisi.Tckn = txtTCKN.Text;
            ListeyiDoldur();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (seciliKisi == null) return;

            DialogResult cevap = MessageBox.Show($"{seciliKisi} yi silmek istiyor musunuz?", "Silme onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                kisiler.Remove(seciliKisi);
                ListeyiDoldur();
            }
        }
    }
}
