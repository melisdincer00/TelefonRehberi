namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        List<string> Liste_KisiAdi = new List<string>();
        List<string> Liste_TelefonNo = new List<string>();
        int sayac = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            REHBER.Items.Clear();
        }

        private void buttonRehber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_KisiAdi[i] + " " + Liste_TelefonNo[i] + " ";
                REHBER.Items.Add(deger);
            }

        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            var melisTelefonNo = Liste_TelefonNo.Where((telefon, index) => Liste_KisiAdi[index] == "melis").FirstOrDefault();

            if (melisTelefonNo != null)
            {
                MessageBox.Show("Melisin telefon numarası: " + melisTelefonNo);

            }
            else
            {
                MessageBox.Show("Melis adında bir kişi bulunamadı. ");
            }

        }

        private void buttonKaydet_Click(object sender, EventArgs e)

        {
            Liste_KisiAdi.Add(textBoxKisiAdi.Text);
            Liste_TelefonNo.Add(textBoxTelefonNo.Text);
            sayac++;

           
        }
    }
}