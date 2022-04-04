namespace _14_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {

                Random rnd = new Random();
                int a, b, c ,plafon=15;
                a = rnd.Next(plafon);
                b = rnd.Next(plafon);
                c = rnd.Next(plafon);
                textBox1.Text = a + " " + b + " " + c;
                if (a == b && a == c)
                    Afisare("3 identice", a, b, c);
                else
                if (a == b)
                    Afisare("2 identice", a, b, c);
                else
                    if (a == c)
                    Afisare("2 identice", a, b, c);
                else
                    if (b == c)
                    Afisare("2 identice", a, b, c);
                else
                {

                    int min = Math.Min(Math.Min(a, b), Math.Min(b, c)), max = Math.Max(Math.Max(a, b), Math.Max(b, c)), mid = a + b + c - min - max;
                    if (min + 1 == mid && mid + 1 == max)
                        Afisare("Progresie aritmetica.", a, b, c);
                }
            }



        }
        void Afisare(string s, int a, int b, int c)
        {
            listBox1.Items.Add(a + " " + b + " " + c + " - " + s);
        }
    }
}