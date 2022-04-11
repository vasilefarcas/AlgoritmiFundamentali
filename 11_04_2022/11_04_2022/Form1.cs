namespace _11_04_2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pic1;
        Bitmap pic2;
        Bitmap destination;

        private void Form1_Load(object sender, EventArgs e)
        {
            pic1 = new Bitmap(Image.FromFile(@"../../img1.jpg"));
            pic2 = new Bitmap(Image.FromFile(@"../../img2.jpg"));
            pictureBox1.Image = pic1;
            pictureBox2.Image = pic2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            destination = pic1;
            for (int i = 0; i < pic1.Width; i++)
            {
                for (int j = 0; j < pic1.Height; j++)
                {
                    Color Ts1 = pic1.GetPixel(i, j);
                    Color Ts2 = pic2.GetPixel(i, j);
                    Color Td;
                    int r = (Ts1.R + Ts2.R) / 2;
                    int g = (Ts1.G + Ts2.G) / 2;
                    int b = (Ts1.B + Ts2.B) / 2;
                    Td = Color.FromArgb(r, g, b);
                    destination.SetPixel(i, j, Td);
                }
            }
            destination.Save(@"..\..\FarcasVasile-Isai.png");
            pictureBox3.Image = destination;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            destination = pic1;
            for (int i = 0; i < pic1.Width; i++)
            {
                for (int j = 0; j < pic1.Height; j++)
                {
                    Color Ts1 = pic1.GetPixel(i, j);
                    Color Ts2 = pic2.GetPixel(i, j);
                    Color Td;
                    int r = Math.Max(Ts1.R, Ts2.R);
                    int g = Math.Max(Ts1.G, Ts2.G);
                    int b = Math.Max(Ts1.B, Ts2.B);
                    Td = Color.FromArgb(r, g, b);
                    destination.SetPixel(i, j, Td);
                }
            }
            destination.Save(@"..\..\FarcasVasile-Isai_Max.png");
            pictureBox3.Image = destination;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            destination = pic1;
            for (int i = 0; i < pic1.Width; i++)
            {
                for (int j = 0; j < pic1.Height; j++)
                {
                    Color Ts1 = pic1.GetPixel(i, j);
                    Color Ts2 = pic2.GetPixel(i, j);
                    Color Td;
                    int r = Math.Min(Ts1.R, Ts2.R);
                    int g = Math.Min(Ts1.G, Ts2.G);
                    int b = Math.Min(Ts1.B, Ts2.B);
                    Td = Color.FromArgb(r, g, b);
                    destination.SetPixel(i, j, Td);
                }
            }
            destination.Save(@"..\..\FarcasVasile-Isai_Min.png");
            pictureBox3.Image = destination;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int stripes_width = 5;
            destination = GetStriped(pic1, pic2, stripes_width);

            destination.Save(@"..\..\FarcasVasile-Isai_Striped.png");
            pictureBox3.Image = destination;
        }

        private void Animation_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = GetStriped(pic1, pic2, 15);
            destination = GetStriped(pic1, pic2, 15);
            destination.Save(@"..\..\FarcasVasile-Isai_Striped.png");
        }


        private void blur_Button_Click(object sender, EventArgs e)
        {
            destination = pic1;
            int dimension_of_pixels = 3;
            for (int i = 0; i < pic1.Width; i += dimension_of_pixels)
            {
                for (int j = 0; j < pic1.Height; j += dimension_of_pixels)
                {
                    Color Ts = pic1.GetPixel(i, j);
                    for (int l = 0; l < dimension_of_pixels; l++)
                    {
                        for (int m = 0; m < dimension_of_pixels; m++)
                        {
                            destination.SetPixel((i + l) % pic1.Width, (j + m) % pic1.Height, Ts);
                        }
                    }
                }
            }
            destination.Save(@"..\..\FarcasVasile-Isai_Blur.png");
            pictureBox3.Image = destination;
        }

        Bitmap GetStriped(Bitmap pic1, Bitmap pic2, int stripes_width)
        {
            destination = pic1;
            for (int i = 0; i < pic1.Width; i++)
            {
                for (int k = 0; k < stripes_width; k++)
                {
                    for (int j = 0; j < pic1.Height && i < pic1.Width; j++)
                    {
                        Color Ts1 = pic1.GetPixel(i, j);
                        Color Td;
                        int r = Ts1.R;
                        int g = Ts1.G;
                        int b = Ts1.B;
                        Td = Color.FromArgb(r, g, b);
                        destination.SetPixel(i, j, Td);
                    }
                    i++;
                }
                for (int k = 0; k < stripes_width; k++)
                {
                    for (int j = 0; j < pic1.Height && i < pic1.Width; j++)
                    {
                        Color Ts1 = pic2.GetPixel(i, j);
                        Color Td;
                        int r = Ts1.R;
                        int g = Ts1.G;
                        int b = Ts1.B;
                        Td = Color.FromArgb(r, g, b);
                        destination.SetPixel(i, j, Td);
                    }
                    i++;
                }
            }
            return destination;
        }

    }
}