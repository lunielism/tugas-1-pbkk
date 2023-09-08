namespace KalkulatorBiasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tombol Hapus (C)
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Menutup aplikasi
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tombol +
            if (IsValidInput())
            {
                double angka1 = Convert.ToDouble(textBox1.Text);
                double angka2 = Convert.ToDouble(textBox2.Text);
                double hasil = angka1 + angka2;
                textBox3.Text = hasil.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tombol -
            if (IsValidInput())
            {
                double angka1 = Convert.ToDouble(textBox1.Text);
                double angka2 = Convert.ToDouble(textBox2.Text);
                double hasil = angka1 - angka2;
                textBox3.Text = hasil.ToString();
            }
        }
 

        private void button5_Click(object sender, EventArgs e)
        {
            // Tombol *
            if (IsValidInput())
            {
                double angka1 = Convert.ToDouble(textBox1.Text);
                double angka2 = Convert.ToDouble(textBox2.Text);
                double hasil = angka1 * angka2;
                textBox3.Text = hasil.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Tombol /
            if (IsValidInput())
            {
                double angka1 = Convert.ToDouble(textBox1.Text);
                double angka2 = Convert.ToDouble(textBox2.Text);

                // Menghindari pembagian oleh nol
                if (angka2 != 0)
                {
                    double hasil = angka1 / angka2;
                    textBox3.Text = hasil.ToString();
                }
                else
                {
                    MessageBox.Show("Pembagian oleh nol tidak diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private bool IsValidInput()
        {
            double angka1, angka2;
            if (double.TryParse(textBox1.Text, out angka1) && double.TryParse(textBox2.Text, out angka2))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid di kedua kotak teks.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}