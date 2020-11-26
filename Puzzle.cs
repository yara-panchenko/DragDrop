using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDrop
{
    public partial class Puzzle : Form
    {
        bool pictureBox2Clicked = false;
        bool pictureBox3Clicked = false;
        bool pictureBox4Clicked = false;
        bool pictureBox5Clicked = false;
        int picturebox2X = 0;
        int picturebox2Y = 0;
        int picturebox3X = 0;
        int picturebox3Y = 0;
        int picturebox4X = 0;
        int picturebox4Y = 0;
        int picturebox5X = 0;
        int picturebox5Y = 0;
        int X, Y, dX, dY;
        Point MouseDownLocation;
        int rndLocation, rndLocation2;
        Random random, rnd;        
        public Puzzle()
        {
            InitializeComponent();
            Random random = new Random();
            Random rnd = new Random();
            rndLocation = random.Next(1, 5);
            rndLocation2 = rnd.Next(1, 4);
            if (rndLocation2 == 1)
            {
                pictureBox1.Image = Properties.Resources.img1;
                pictureBox2.Image = Properties.Resources.img11;
                pictureBox3.Image = Properties.Resources.img12;
                pictureBox4.Image = Properties.Resources.img13;
                pictureBox5.Image = Properties.Resources.img14;
            }
            else if (rndLocation2 == 2)
            {
                pictureBox1.Image = Properties.Resources.img2;
                pictureBox2.Image = Properties.Resources.img21;
                pictureBox3.Image = Properties.Resources.img22;
                pictureBox4.Image = Properties.Resources.img23;
                pictureBox5.Image = Properties.Resources.img24;
            }
            else if (rndLocation2 == 3)
            {
                pictureBox1.Image = Properties.Resources.img3;
                pictureBox2.Image = Properties.Resources.img31;
                pictureBox3.Image = Properties.Resources.img32;
                pictureBox4.Image = Properties.Resources.img33;
                pictureBox5.Image = Properties.Resources.img34;
            }
        }        

        private void Puzzle_Load(object sender, EventArgs e)
        {
            
        }  
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Size= new System.Drawing.Size(313, 313);
            if (rndLocation == 1)
            {
                pictureBox2.Location= new Point(0, 0);
                pictureBox3.Location = new Point(313, 0);
                pictureBox4.Location = new Point(0, 313);
                pictureBox5.Location = new Point(313, 313);
            }
            else if (rndLocation == 2)
            {
                pictureBox2.Location = new Point(313, 0);
                pictureBox3.Location = new Point(0, 313);
                pictureBox4.Location = new Point(0, 0);
                pictureBox5.Location = new Point(313, 313);
            }
            else if (rndLocation == 3)
            {
                pictureBox2.Location = new Point(0, 313);
                pictureBox3.Location = new Point(0, 0);
                pictureBox4.Location = new Point(313, 313);
                pictureBox5.Location = new Point(313, 0);
            }
            else if (rndLocation == 4)
            {
                pictureBox2.Location = new Point(313, 313);
                pictureBox3.Location = new Point(313, 0);
                pictureBox4.Location = new Point(0, 313);
                pictureBox5.Location = new Point(0, 0);
            }
            pictureBox2.Visible = true;
            pictureBox3.Size = new System.Drawing.Size(313, 313);
            pictureBox3.Visible = true;
            pictureBox4.Size = new System.Drawing.Size(313, 313);
            pictureBox4.Visible = true;
            pictureBox5.Size = new System.Drawing.Size(313, 313);
            pictureBox5.Visible = true;
            label1.Visible = true;
            button2.Visible = true;
        }
        
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox2.Left = e.X + pictureBox2.Left - MouseDownLocation.X;
                pictureBox2.Top = e.Y + pictureBox2.Top - MouseDownLocation.Y;
            }
            if (e.X == pictureBox6.Location.X)
            {
                if (e.Y == pictureBox6.Location.Y)
                {
                    pictureBox2.Location = pictureBox6.Location;
                }
            }
            if (e.X == pictureBox7.Location.X)
            {
                if (e.Y == pictureBox7.Location.Y)
                {
                    pictureBox2.Location = pictureBox7.Location;
                }
            }
            if (e.X == pictureBox8.Location.X)
            {
                if (e.Y == pictureBox8.Location.Y)
                {
                    pictureBox2.Location = pictureBox8.Location;
                }
            }
            if (e.X == pictureBox9.Location.X)
            {
                if (e.Y == pictureBox9.Location.Y)
                {
                    pictureBox2.Location = pictureBox9.Location;
                }
            }
        }
            
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox3.Left = e.X + pictureBox3.Left - MouseDownLocation.X;
                pictureBox3.Top = e.Y + pictureBox3.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox4.Left = e.X + pictureBox4.Left - MouseDownLocation.X;
                pictureBox4.Top = e.Y + pictureBox4.Top - MouseDownLocation.Y;
            }
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBox5.Left = e.X + pictureBox5.Left - MouseDownLocation.X;
                pictureBox5.Top = e.Y + pictureBox5.Top - MouseDownLocation.Y;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rndLocation == 1)
            {
                pictureBox2.Location = new Point(0, 0);
                pictureBox3.Location = new Point(313, 0);
                pictureBox4.Location = new Point(0, 313);
                pictureBox5.Location = new Point(313, 313);
            }
            else if (rndLocation == 2)
            {
                pictureBox2.Location = new Point(313, 0);
                pictureBox3.Location = new Point(0, 313);
                pictureBox4.Location = new Point(0, 0);
                pictureBox5.Location = new Point(313, 313);
            }
            else if (rndLocation == 3)
            {
                pictureBox2.Location = new Point(0, 313);
                pictureBox3.Location = new Point(0, 0);
                pictureBox4.Location = new Point(313, 313);
                pictureBox5.Location = new Point(313, 0);
            }
            else if (rndLocation == 4)
            {
                pictureBox2.Location = new Point(313, 313);
                pictureBox3.Location = new Point(313, 0);
                pictureBox4.Location = new Point(0, 313);
                pictureBox5.Location = new Point(0, 0);
            }
        }

        private void Puzzle_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Location == pictureBox6.Location && pictureBox3.Location == pictureBox8.Location &&
                pictureBox4.Location == pictureBox7.Location && pictureBox5.Location == pictureBox9.Location)
            {
                pictureBox6.SendToBack();
                pictureBox7.SendToBack();
                pictureBox8.SendToBack();
                pictureBox9.SendToBack();
                MessageBox.Show("Пазл собран!");
                label1.Text = "Вы молодец!";
            }
            else
            {

            }
        }
        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {
        }
        private void Puzzle_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Location == pictureBox6.Location && pictureBox3.Location == pictureBox8.Location &&
                pictureBox4.Location == pictureBox7.Location && pictureBox5.Location == pictureBox9.Location)
            {
                label1.Text = "Вы молодец!";
            }
            //if (pictureBox2Clicked)
            //{
            //    pictureBox2.X = e.X - picturebox2X;
            //    pictureBox2.Y = e.Y - picturebox2Y;
            //}
            //if (pictureBox3Clicked)
            //{
            //    pictureBox3.X = e.X - picturebox3X;
            //    pictureBox3.Y = e.Y - picturebox3Y;
            //}
            //if (pictureBox4Clicked)
            //{
            //    pictureBox4.X = e.X - picturebox4X;
            //    pictureBox4.Y = e.Y - picturebox4Y;
            //}
            //if (pictureBox5Clicked)
            //{
            //    pictureBox5.X = e.X - picturebox5X;
            //    pictureBox5.Y = e.Y - picturebox5Y;
            //}
        }
    }
}
