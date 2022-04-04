using System.IO;
namespace _24_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"..\..\..\TextIn.txt");
           // int n = int.Parse(load.ReadLine());
            int[] v = new int[100];
          /*
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(load.ReadLine());
            }
          */
            int q = 0;
            string sir = load.ReadLine();
            while (sir != null)
            {
                string[] num = sir.Split(' ');
                int nr = num.Length;
                for (int j = 0; j < nr; j++)
                    v[j + q] = int.Parse(num[j]);
                q += nr;
                sir = load.ReadLine();
            }
            TextWriter write = new StreamWriter(@"..\..\..\TextOut.txt");
            for (int i = 0; i < q; i++)
            {
                write.WriteLine(v[i]);
                listBox1.Items.Add(v[i]);

            }

        }
    }
}