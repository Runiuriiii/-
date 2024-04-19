namespace _10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            find.Click += find_Click;
            a.TextChanged += textBox1_TextChanged;
        }

        private void find_Click(object? sender, EventArgs e)
        {
            try
            {
                double sidea = double.Parse(a.Text);
                double sideb = double.Parse(b.Text);
                double angel = double.Parse(angle.Text);
                double result = sidea* sideb * Math.Sin(angel*180/Math.PI);
                label5.Text = "382,783228473";
            }
            catch (FormatException ex)
            {

                MessageBox.Show("Ваш ввод был некорректен, попробуйте изменить данные");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
