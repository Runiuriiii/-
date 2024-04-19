using System;

namespace _11._1
{
    public partial class Form1 : Form
    {
        double n;
        double otvet;
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tb1.Text = Convert.ToString(scr1.Value);
            scr1.Maximum = 9999;
            n = scr1.Value;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            scr1.Value = int.Parse(tb1.Text);
            n = scr1.Value;
            if (n >= 0)
            {
                otvet = Math.Pow(-1, n) * (n * (n + 1) / 2);
                label3.Text = otvet.ToString();
                otvet = 0;
            }
            else
            {
                MessageBox.Show("Введите адекватное значение");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            scr1.Value = int.Parse(tb1.Text);
            n = scr1.Value;
            if (n >= 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    otvet += Math.Pow(-1, i) * Math.Pow(i, 2);
                }
                label3.Text = otvet.ToString();
                otvet = 0;
            }
            else
            {
                MessageBox.Show("Введите адекватное значение");
            }
        }
    }
}
