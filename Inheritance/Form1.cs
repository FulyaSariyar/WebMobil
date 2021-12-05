namespace Inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sekil k1 = new Kare(10);
            Sekil k2 = new Kare(5);
            Sekil d1 = new Dikdörtgen(3, 4);
            Sekil d2 = new Dikdörtgen(5, 12);
            Sekil da1 = new Daire(7);
            Sekil da2 = new Daire(8);
            Sekil u1 = new DikUcgen(6, 8);
            Sekil u2 = new DikUcgen(10, 24);

            Sekiller.Items.Add(k1);
            Sekiller.Items.Add(k2);
            Sekiller.Items.Add(d1);
            Sekiller.Items.Add(d2);
            Sekiller.Items.Add(da1);
            Sekiller.Items.Add(da2);
            Sekiller.Items.Add(u1);
            Sekiller.Items.Add(u2);
        }

        private void Sekiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sekiller.SelectedItem == null) return;

            //Sekil seciliSekil = lstSekiller.SelectedItem as Sekil;
            Sekil seciliSekil = (Sekil)Sekiller.SelectedItem;

            if (seciliSekil is Kare)
            {

            }
            else if (seciliSekil is Dikdörtgen)
            {
                Dikdörtgen dd = seciliSekil as Dikdörtgen;

            }
            else if (seciliSekil is Daire dd)
            {
                this.Text = dd.Cap().ToString();
            }

            label1.Text =
                $"Alaný: {seciliSekil.AlanHesapla()}\nÇevresi: {seciliSekil.CevreHesapla()}\nKöþegen Uzunluðu:{seciliSekil.KosegenHesapla()}";
        }
    }
}