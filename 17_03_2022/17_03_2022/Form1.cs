using System.IO;
namespace _17_03_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"..\..\TextFile1.txt");
            int n=int.Parse(load.ReadLine());
            string[] v = load.ReadLine().Split(' ');
            int[] q=new int[v.Length];
            for (int i = 0; i < n; i++)
            {
                q[i]=int.Parse(v[i]);
                listBox1.Items.Add(v[i]);
            }
        }
    }
}