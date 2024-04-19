using System.Windows.Forms;

namespace _11._2
{
    public struct Note
    {
        public string fio;
        public string number;
        public string date;

        public override string ToString()
        {
            return $"{fio} - {number} - {date}";
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            File.WriteAllText(filePath, string.Empty);
            GeneratePeople();
            Files(filePath, birthdateList);
            FileRead(filePath);
        }
        string filePath = @"C:\Users\kiril\Desktop\fmd.txt";
        List<string> fnameList = new List<string> { "Иван", "Кирилл", "Николай", "Михаил", "Август", "Александр", "Сергей", "Антон", "Игорь", "Ярослав" };
        List<Note> noteNumber = new List<Note>();
        List<Note> birthdateList = new List<Note>();
        List<string> lnameList = new List<string> { "Аврорин", "Ламбин", "Вешняков", "Вышеславцев", "Уледов", "Езерский", "Белевский", "Вавилов", "Виноградов", "Лебедев" };
        private void GeneratePeople()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                string phNumber = (rand.Next(966000000, 966999999)).ToString();
                string FIO = fnameList[rand.Next(0, fnameList.Count)] + " " + lnameList[rand.Next(0, lnameList.Count)];
                string birthdate = (rand.Next(1, 28)).ToString() + "." + (rand.Next(1, 12)).ToString() + "." + (rand.Next(1950, 2023)).ToString();

                Note person = new Note { fio = FIO, number = phNumber, date = birthdate };
                birthdateList.Add(person);
            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string person = phonenumber.Text;
            List<Note> sortedBirthdateList = birthdateList.OrderBy(a => a.fio).ToList();
            Search(person, sortedBirthdateList);

        }
        private void Search(string person, List<Note> sortedBirthdateList)
        {
            IOrderedEnumerable<Note>? sortedList = birthdateList.Where(a => a.number == person).OrderBy(a => a.fio);
            List<Note> listResult = new List<Note>();
            if (sortedList.Any())
            {
                listResult = sortedList.ToList();
                resulted.DataSource = listResult;
                resulted.DisplayMember = "{fio} - {number} - {date}";
            }
            else
            {
                MessageBox.Show($"{person} не существует");
            }
        }
        private void Files(string filePath, List<Note> birthdateList)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Note person in birthdateList)
                {
                    writer.WriteLine($": {person.fio}, Номер телефона: {person.number}, Дата рождения: {person.date}");
                }
            }
        }
        private void FileRead(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                all.Items.Add(line);
            }
        }
        private void labelPlaneModel_Click(object sender, EventArgs e)
        {

        }

        private void resulted_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void phonenubmer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Note> sortedBirthdateList = birthdateList.OrderBy(a => a.fio).ToList();
            
            all.DataSource = sortedBirthdateList;
            resulted.DisplayMember = "{fio} - {number} - {date}";
        }

        private void all_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
