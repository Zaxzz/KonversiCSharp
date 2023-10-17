namespace Nilai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int nilai) && nilai >= 0 && nilai <= 100)
            {
                string predikat = "";

                if (nilai >= 91 && nilai <= 100)
                {
                    predikat = "Amat Baik";
                }
                else if (nilai >= 81 && nilai <= 90)
                {
                    predikat = "Baik";
                }
                else if (nilai >= 71 && nilai <= 80)
                {
                    predikat = "Cukup baik";
                }
                else if (nilai >= 61 && nilai <= 70)
                {
                    predikat = "Cukup";
                }
                else
                {
                    predikat = "Kurang";
                }

                textBox3.Text = $"{predikat}";
            }
            else
            {
                textBox3.Text = "Input angka 0-100";
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}