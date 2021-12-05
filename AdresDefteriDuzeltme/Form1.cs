namespace AdresDefteriDuzeltme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kisi kisi = new Kisi();
        private List<Kisi> kisiler = new List<Kisi>();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            try
            {
                yeniKisi.Ad = txtAd.Text;
                yeniKisi.Soyad = txtSoyad.Text;
                yeniKisi.DogumTarihi = dateTimePicker1.Value;
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
            Kisiler.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                Kisiler.Items.Add(kisi1);
            }
        }
        private Kisi seciliKisi;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            if (seciliKisi == null) return;

            seciliKisi.Ad = txtAd.Text;
            seciliKisi.Soyad = txtSoyad.Text;
            seciliKisi.DogumTarihi = dateTimePicker1.Value;
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

        private void Kisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Kisiler.SelectedItem == null) return;

            seciliKisi = Kisiler.SelectedItem as Kisi;

            txtAd.Text = seciliKisi.Ad;
            txtSoyad.Text = seciliKisi.Soyad;
            txtTCKN.Text = seciliKisi.Tckn;
            dateTimePicker1.Value = seciliKisi.DogumTarihi;
        }
    }
}