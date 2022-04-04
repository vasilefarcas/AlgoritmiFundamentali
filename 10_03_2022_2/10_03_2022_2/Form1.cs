using System.IO;
namespace _10_03_2022_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReader load = new StreamReader(@"..\..\Resurse\in.txt");
            string buffer;
            List<string> data = new List<string>();
            while((buffer= load.ReadLine())!=null)
                data.Add(buffer);
            for (int i = 0; i < data.Count; i++)
            {
                string[] tmp = data[i].Split(new char[] { ' ', ',' });
                for (int j = 0; j < tmp.Length; j++)
                {
                    int itmp=int.Parse(tmp[j]);
                    if(PrimaUltima(itmp)==1)
                        listBox1.Items.Add(itmp.ToString());
                }
            }
            
            
        }


        public int PrimaUltima(int n)
        {
            int p = n % 10;
            while (n > 10)
                n /= 10;
            if (p == n)
            {
                return 1;
            }
            return 0;
        }
    }
}