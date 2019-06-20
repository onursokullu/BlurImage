using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlurImage
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        Point LocationXY;
        Point LocationX1Y1;
        bool IsMouseDown = false;
        int blurIntensity=3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;

            }
    
            picBoxSmall.ImageLocation = openFileDialog1.FileName;
            picBoxBig.ImageLocation = openFileDialog1.FileName;

            //  btnConvertGray.PerformClick();



        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }


        //private void picBoxBig_Click_1(object sender, EventArgs e)
        //{
          
        //    this.picBoxBig.Name = "picBoxBig";
            
        //    this.picBoxBig.Click += new System.EventHandler(this.picBoxBig_Click_1);
        //    string labelTex =string.Format("X: {0} X+1: {1} Y: {2} ", MousePosition.X, MousePosition.X+1, MousePosition.Y);
        //    label5.Text = "You choiced the pixel coordinated"+labelTex;

        //    float cons = 1 / 9;



           
        //    for (int i = MousePosition.X - 1; i <= MousePosition.X + 1; i++)
        //    {
        //        for (int j = MousePosition.Y - 1; j <= MousePosition.Y + 1; j++)
        //        {
        //            Console.Write("i: {0} j: {1}", i, j);



        //        }
        //    }

        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MakeItBlur_Click(object sender, EventArgs e)
        {
            Bitmap newBitmap = new Bitmap(picBoxBig.Image);
            for (int x = LocationXY.X; x <= LocationX1Y1.X-1; x++)
            {   
                for (int y = LocationXY.Y; y <= LocationX1Y1.Y; y++)
                {
                    try
                    {
                        Color prevX = newBitmap.GetPixel(x - blurIntensity, y);
                        Color nextY = newBitmap.GetPixel(x + blurIntensity, y);
                        Color prevY = newBitmap.GetPixel(x, y - blurIntensity);
                        Color nextX = newBitmap.GetPixel(x , y + blurIntensity);
                        int avgR = (int)((prevX.R + nextY.R + prevY.R + nextX.R) / 4);
                        int avgG = (int)((prevX.G + nextY.G + prevY.G + nextX.G) / 4);
                        int avgB = (int)((prevX.B + nextY.B + prevY.B + nextX.B) / 4);
                        newBitmap.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                       
                      
                    }
                    catch (Exception) { }
                }

            }
            picBoxBig.Image = newBitmap;


        }

        private void updateBlur(object sender, EventArgs e)
        {

            blurIntensity =int.Parse( trackBar1.Value.ToString()); 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(save.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                picBoxBig.Image.Save(save.FileName, format);
            }
        }

      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            LocationXY = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsMouseDown == true)
            {
                LocationX1Y1 = e.Location;
                IsMouseDown = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (rect != null)
            {
                e.Graphics.DrawRectangle(Pens.Black, GetRect());

            }
        }
        private Rectangle GetRect()
        {
            rect = new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rect;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
