using System.Windows.Forms;

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
            gru = new Gru(1, "Produttore", 309, 146);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y - 5 > gru.HMin)
            {
                gru.Alza(5);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
            }
            else
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, gru.HMin);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Location.Y + 5 < gru.HMax)
            {
                gru.Abbassa(5);
                pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
            }
            else
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X, gru.HMax);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(pictureBox2.Location.X, gru.HMin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox2.Text) >= 146 && Convert.ToInt16(textBox1.Text) <= 309)
                gru.HMin = Convert.ToInt16(textBox2.Text);
            gru.HMax = Convert.ToInt16(textBox1.Text);
            pictureBox2.Location = new Point(pictureBox2.Location.X, gru.HMin);
        }
    }
}
