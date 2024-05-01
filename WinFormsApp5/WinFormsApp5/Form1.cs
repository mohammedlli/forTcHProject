using System.Security.Cryptography;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap btm, btm1, btm2, btm3;

        int w, h;

        byte[,] red;
        byte[,] green;
        byte[,] blue;

        byte[,] gammaCore_red;
        byte[,] gammaCore_green;
        byte[,] gammaCore_blue;

        private void Form1_Load(object sender, EventArgs e)
        {

            hScrollBar1.Minimum=1;
        }

        public void Gamma_Fn(int w, int h, byte[,] I, ref byte[,] IC, double gamma)
        {
            byte[] lookup = new byte[256];

            for (int i = 0; i < 256; i++)
            {
                lookup[i] = (byte)(Math.Pow((i / 255f), (1 / gamma)) * 255);
            }

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    IC[i, j] = lookup[I[i, j]];
                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            gammaCore_red = new byte[w, h];
            gammaCore_green = new byte[w, h];
            gammaCore_blue = new byte[w, h];

            double m = Convert.ToDouble(textBox1.Text);

            Gamma_Fn(w, h, red, ref gammaCore_red, m);
            Gamma_Fn(w, h, green, ref gammaCore_green, m);
            Gamma_Fn(w, h, blue, ref gammaCore_blue, m);

            btm1 = new Bitmap(w, h);

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    btm1.SetPixel(i, j, Color.FromArgb(gammaCore_red[i, j], gammaCore_green[i, j], gammaCore_blue[i, j]));
                }
            }

            pictureBox2.Image = btm1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            btm = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = btm;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            w= btm.Width;
            h= btm.Height;

            red = new byte[w, h];
            green = new byte[w, h];
            blue = new byte[w, h];

            btm2 = new Bitmap(w, h);

            for (int i = 0; i < w; i++)
            {


                for (int j = 0; j < h; j++)
                {
                    Color p = btm.GetPixel(i, j);
                    red[i, j]= p.R;
                    btm2.SetPixel(i, j, Color.FromArgb(red[i, j], 0, 0));
                }
            }

            pictureBox3.Image = btm2;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            double value = hScrollBar1.Value;

            double x = value;

            if (x == 0 || x==1) x= 1;
            else if (x == 2) x= 0.1;
            else if (x==3) x=0.2;
            else if (x == 4) x=0.3;
            else if (x == 5) x= 0.4;
            else if (x == 6) x=0.5;
            else if (x == 7) x=0.6;
            else if (x == 8) x=0.7;
            else if (x == 9) x=0.8;
            else if (x == 10) x=0.9;
            else if (x > 10) hScrollBar1.Value = 1;

            textBox1.Text = x.ToString();
        }
    }
}