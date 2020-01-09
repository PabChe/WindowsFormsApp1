using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                g.DrawLine(new Pen(Color.Black, 1), 105, 40, 155, 40); // sheya

                g.DrawLine(new Pen(Color.Black, 1), 105, 40, 110, 50); // 8p vorot
                g.DrawLine(new Pen(Color.Black, 1), 155, 40, 150, 50);
                g.DrawLine(new Pen(Color.Black, 1), 110, 50, 115, 55);
                g.DrawLine(new Pen(Color.Black, 1), 150, 50, 145, 55);
                g.DrawLine(new Pen(Color.Black, 1), 115, 55, 122, 58);
                g.DrawLine(new Pen(Color.Black, 1), 145, 55, 138, 58);
                g.DrawLine(new Pen(Color.Black, 1), 122, 58, 130, 60);
                g.DrawLine(new Pen(Color.Black, 1), 138, 58, 130, 60);

                g.DrawLine(new Pen(Color.Black, 1), 105, 40, 65, 60); // plechi
                g.DrawLine(new Pen(Color.Black, 1), 155, 40, 195, 60);
                g.DrawLine(new Pen(Color.Black, 1), 65, 60, 80, 100);
                g.DrawLine(new Pen(Color.Black, 1), 195, 60, 180, 100);

                g.DrawLine(new Pen(Color.Black, 1), 65, 60, 40, 100); // 6p ruki
                g.DrawLine(new Pen(Color.Black, 1), 195, 60, 220, 100);
                g.DrawLine(new Pen(Color.Black, 1), 40, 100, 70, 120);
                g.DrawLine(new Pen(Color.Black, 1), 220, 100, 190, 120);
                g.DrawLine(new Pen(Color.Black, 1), 70, 120, 80, 100);
                g.DrawLine(new Pen(Color.Black, 1), 190, 120, 180, 100);

                g.DrawLine(new Pen(Color.Black, 1), 80, 100, 80, 260); // tul
                g.DrawLine(new Pen(Color.Black, 1), 180, 100, 180, 260);
                g.DrawLine(new Pen(Color.Black, 1), 80, 260, 180, 260);

            }

            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            using (Graphics g = Graphics.FromImage(pictureBox2.Image))
            {
                g.Clear(Color.White);
                g.DrawLine(new Pen(Color.Black, 1), 105, 40, 155, 40); // sheya

                g.DrawLine(new Pen(Color.Black, 1), 105, 40, 65, 60); // plechi
                g.DrawLine(new Pen(Color.Black, 1), 155, 40, 195, 60);
                g.DrawLine(new Pen(Color.Black, 1), 65, 60, 80, 100);
                g.DrawLine(new Pen(Color.Black, 1), 195, 60, 180, 100);

                g.DrawLine(new Pen(Color.Black, 1), 65, 60, 40, 100); // 6p ruki
                g.DrawLine(new Pen(Color.Black, 1), 195, 60, 220, 100);
                g.DrawLine(new Pen(Color.Black, 1), 40, 100, 70, 120);
                g.DrawLine(new Pen(Color.Black, 1), 220, 100, 190, 120);
                g.DrawLine(new Pen(Color.Black, 1), 70, 120, 80, 100);
                g.DrawLine(new Pen(Color.Black, 1), 190, 120, 180, 100);

                g.DrawLine(new Pen(Color.Black, 1), 80, 100, 80, 260); // tul
                g.DrawLine(new Pen(Color.Black, 1), 180, 100, 180, 260);
                g.DrawLine(new Pen(Color.Black, 1), 80, 260, 180, 260);

            }


            this.Controls.Add(button2);
            button2.Visible = true;
            this.Controls.Add(button3);
            button3.Visible = true;
            button1.Visible = false;
            this.Controls.Add(button4);
            button4.Visible = true;
            this.Controls.Add(button5);

            this.Controls.Add(textBox2);
            textBox2.Show();
            this.Controls.Add(textBox3);
            textBox3.Show();
            this.Controls.Add(textBox4);
            textBox4.Show();
            this.Controls.Add(textBox5);
            textBox5.Show();


            this.Controls.Add(button6); //bd
            button6.Show();
            this.Controls.Add(button7);
            button7.Show();
            this.Controls.Add(button8);
            button8.Show();
            this.Controls.Add(button9);
            button9.Show();
            this.Controls.Add(button10);
            button10.Show();
            this.Controls.Add(button11);
            button11.Show();
            this.Controls.Add(button12);
            button12.Show();
            this.Controls.Add(button13);
            button13.Show();
            this.Controls.Add(button14);
            button14.Show();
            this.Controls.Add(button15);
            button15.Show();
            this.Controls.Add(button16);
            button16.Show();
            this.Controls.Add(button17);
            button17.Show();
            ////////////////////////////////
            this.Controls.Add(button18); //l sh
            button18.Show();
            this.Controls.Add(button19);
            button19.Show();
            this.Controls.Add(button20);
            button20.Show();
            this.Controls.Add(button21);
            button21.Show();
            this.Controls.Add(button22);
            button22.Show();
            this.Controls.Add(button23);
            button23.Show();
            this.Controls.Add(button24);
            button24.Show();
            this.Controls.Add(button25);
            button25.Show();
            this.Controls.Add(button26);
            button26.Show();
            this.Controls.Add(button27);
            button27.Show();
            this.Controls.Add(button28);
            button28.Show();
            this.Controls.Add(button29);
            button29.Show();
            ////////////////////////////////
            this.Controls.Add(button30); // r sh
            button30.Show();
            this.Controls.Add(button31);
            button31.Show();
            this.Controls.Add(button32);
            button32.Show();
            this.Controls.Add(button33);
            button33.Show();
            this.Controls.Add(button34);
            button34.Show();
            this.Controls.Add(button35);
            button35.Show();
            this.Controls.Add(button36);
            button36.Show();
            this.Controls.Add(button37);
            button37.Show();
            this.Controls.Add(button38);
            button38.Show();
            this.Controls.Add(button39);
            button39.Show();
            this.Controls.Add(button40);
            button40.Show();
            this.Controls.Add(button41);
            button41.Show();
            /////////////////////////////////
            this.Controls.Add(button42); // ch
            button42.Show();
            this.Controls.Add(button43);
            button43.Show();
            this.Controls.Add(button44);
            button44.Show();
            this.Controls.Add(button45);
            button45.Show();
            this.Controls.Add(button46);
            button46.Show();
            this.Controls.Add(button47);
            button47.Show();
            this.Controls.Add(button48);
            button48.Show();
            this.Controls.Add(button49);
            button49.Show();
            this.Controls.Add(button50);
            button50.Show();
            this.Controls.Add(button51);
            button51.Show();
            this.Controls.Add(button52);
            button52.Show();
            this.Controls.Add(button53);
            button53.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox1);
            button1.Visible = true;
            this.Controls.Remove(button2);
            this.Controls.Remove(button3);
            this.Controls.Remove(button4);
            this.Controls.Remove(pictureBox2);
            this.Controls.Remove(button5);

            this.Controls.Remove(textBox2);
            this.Controls.Remove(textBox3);
            this.Controls.Remove(textBox4);
            this.Controls.Remove(textBox5);


            this.Controls.Remove(button6);
            this.Controls.Remove(button7);
            this.Controls.Remove(button8);
            this.Controls.Remove(button9);
            this.Controls.Remove(button10);
            this.Controls.Remove(button11);
            this.Controls.Remove(button12);
            this.Controls.Remove(button13);
            this.Controls.Remove(button14);
            this.Controls.Remove(button15);
            this.Controls.Remove(button16);
            this.Controls.Remove(button17);
            this.Controls.Remove(button18);
            this.Controls.Remove(button19);
            this.Controls.Remove(button20);
            this.Controls.Remove(button21);
            this.Controls.Remove(button22);
            this.Controls.Remove(button23);
            this.Controls.Remove(button24);
            this.Controls.Remove(button25);
            this.Controls.Remove(button26);
            this.Controls.Remove(button27);
            this.Controls.Remove(button28);
            this.Controls.Remove(button29);
            this.Controls.Remove(button30);
            this.Controls.Remove(button31);
            this.Controls.Remove(button32);
            this.Controls.Remove(button33);
            this.Controls.Remove(button34);
            this.Controls.Remove(button35);
            this.Controls.Remove(button36);
            this.Controls.Remove(button37);
            this.Controls.Remove(button38);
            this.Controls.Remove(button39);
            this.Controls.Remove(button40);
            this.Controls.Remove(button41);
            this.Controls.Remove(button42);
            this.Controls.Remove(button43);
            this.Controls.Remove(button44);
            this.Controls.Remove(button45);
            this.Controls.Remove(button46);
            this.Controls.Remove(button47);
            this.Controls.Remove(button48);
            this.Controls.Remove(button49);
            this.Controls.Remove(button50);
            this.Controls.Remove(button51);
            this.Controls.Remove(button52);
            this.Controls.Remove(button53);


            textBox1.Visible = true;
        }

        int clickCount;
        private void button3_Click(object sender, EventArgs e) // save
        {
            clickCount++;
            Bitmap bmp = new Bitmap(pictureBox1.Width * 2, pictureBox1.Height);

            pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            pictureBox2.DrawToBitmap(bmp, new Rectangle(pictureBox1.Width, 0, pictureBox2.Width, pictureBox2.Height));
            bmp.Save("Model" + clickCount, System.Drawing.Imaging.ImageFormat.Jpeg);
            
            DialogResult result = MessageBox.Show(
                "We have started working on your order, do you want to share the image with your friends(the image will be copied to the clipboard)?",
                "Order is accepted",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes)
                Clipboard.SetImage(bmp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            
            button5.Visible = true;
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;

            button4.Visible = true;
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e) // bd
        {
           var button = (Button)sender;
           int x, y;

            if (pictureBox1.Visible == true){
                for (y = 101; y < 260; y++)
                {
                    for (x = 81; x < 180; x++)
                    {
                        ((Bitmap)pictureBox1.Image).SetPixel(x, y, button.BackColor);
                    }
                }
            }

            if (pictureBox2.Visible == true)
            {
                for (y = 101; y < 260; y++)
                {
                    for (x = 81; x < 180; x++)
                    {
                        ((Bitmap)pictureBox2.Image).SetPixel(x, y, button.BackColor);
                    }
                }
            }

            pictureBox1.Invalidate();
            pictureBox1.Update();
            pictureBox2.Invalidate();
            pictureBox2.Update();
        }


        private void button42_Click(object sender, EventArgs e) //ch
        {
            var button = (Button)sender;

            if (pictureBox1.Visible == true)
            {
                Point[] points = { new Point(105, 41),
                new Point(110, 51),
                new Point(115, 56),
                new Point(122, 59),
                new Point(130, 61),
                new Point(138, 59),
                new Point(145, 56),
                new Point(150, 51),
                new Point(155, 41),
                new Point(194, 60),
                new Point(179, 101),
                new Point(81, 101),
                new Point(66, 60) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            if (pictureBox2.Visible == true)
            {
                Point[] points = { new Point(105, 41),
                new Point(155, 41),
                new Point(194, 60),
                new Point(179, 101),
                new Point(81, 101),
                new Point(66, 60) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox2.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            pictureBox1.Invalidate();
            pictureBox1.Update();
            pictureBox2.Invalidate();
            pictureBox2.Update();
        }

        

        private void button18_Click(object sender, EventArgs e) // l sh
        {
            var button = (Button)sender;

            if (pictureBox1.Visible == true)
            {
                Point[] points = { new Point(65, 61),
                new Point(79, 100),
                new Point(70, 119),
                new Point(41, 100) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            if (pictureBox2.Visible == true)
            {
                Point[] points = { new Point(65, 61),
                new Point(79, 100),
                new Point(70, 119),
                new Point(41, 100) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox2.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            pictureBox1.Invalidate();
            pictureBox1.Update();
            pictureBox2.Invalidate();
            pictureBox2.Update();
        }


        private void button30_Click(object sender, EventArgs e) // r sh
        {
            var button = (Button)sender;

            if (pictureBox1.Visible == true)
            {
                Point[] points = { new Point(195, 61),
                new Point(219, 100),
                new Point(190, 119),
                new Point(181, 100) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            if (pictureBox2.Visible == true)
            {
                Point[] points = { new Point(195, 61),
                new Point(219, 100),
                new Point(190, 119),
                new Point(181, 100) };
                SolidBrush brush = new SolidBrush(button.BackColor);

                using (Graphics g = Graphics.FromImage(pictureBox2.Image))
                {
                    g.FillPolygon(brush, points);
                }
            }

            pictureBox1.Invalidate();
            pictureBox1.Update();
            pictureBox2.Invalidate();
            pictureBox2.Update();
        }

    }
}
