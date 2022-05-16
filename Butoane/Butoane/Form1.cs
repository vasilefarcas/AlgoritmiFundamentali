using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Butoane
{
    public partial class Form1 : Form
    {
        IButton[,] T;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 20;
            int m = 14;
            T = new IButton[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    T[i, j] = new IButton();
                    T[i, j].Size = new Size(20, 20);
                    T[i, j].Parent = this;
                    T[i, j].Location = new Point(120 + i * 21, 120 + j * 21);
                    T[i, j].Click += Form1_Click;
                    T[i, j].linie = i;
                    T[i, j].coloana = j;
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            int l = (sender as IButton).linie;
            int c = (sender as IButton).coloana;
            MessageBox.Show($"ai apasat pe butonul {l} {c}");
        }
    }
}
