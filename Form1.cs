using Newtonsoft.Json.Linq;
using System.Security.Policy;


namespace WinFormsApp1
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f33 = new Form3();
            f33.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 formExib = new Form2();
            formExib.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            Environment.Exit(0);
        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void setvalor()
        {

        }

        private void imagem_Click(object sender, EventArgs e)
        {

        }



    }
}




