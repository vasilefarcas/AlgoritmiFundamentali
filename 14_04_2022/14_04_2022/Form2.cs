using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_04_2022
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cplx z1 = new Cplx();
            z1.init(1, 0);
            Cplx z2 = new Cplx();
            z2.init(2, 3);
            Cplx z3 = new Cplx();
            z3.init(1, -2);
        }
    }
}
