namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Gru gru;
        StazioneDiRadiocomando stazione;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gru.Alza(5);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gru.Abbassa(5);
            pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(347, 195);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gru = new Gru(1, "Produttore", Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

        }
    }
}
