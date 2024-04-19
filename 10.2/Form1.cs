namespace _10._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                double n = double.Parse(textBox1.Text);
                double result = n*(n+1)/2;
                otvet.Text = result.ToString();
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Ваш ввод был некорректен, попробуйте изменить данные");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
