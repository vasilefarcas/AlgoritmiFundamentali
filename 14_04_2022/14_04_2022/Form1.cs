namespace _14_04_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Cplx sum(Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re=a.re+b.re;
            t.im=a.im+b.im;
            return t;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Cplx a = new Cplx();
            a.init(2, 3);
            listBox1.Items.Add(a.view());
            Cplx b = new Cplx();
            b.init(2, -3);
            listBox1.Items.Add(b.view());
            Cplx t = a.sum(b);
            listBox1.Items.Add(t.view());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.Show();
        }
    }
}