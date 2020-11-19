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
        Random random;
        int rndLocation;
        public Puzzle()
        {
            InitializeComponent();
            Random random = new Random();
            rndLocation = random.Next(1, 5);
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
            //pictureBox2.Location =new Point (0, 0);
            pictureBox2.Visible = true;
            pictureBox3.Size = new System.Drawing.Size(313, 313);
            //pictureBox3.Location = new Point(313, 0);
            pictureBox3.Visible = true;
            pictureBox4.Size = new System.Drawing.Size(313, 313);
            //pictureBox4.Location = new Point(0, 313);
            pictureBox4.Visible = true;
            pictureBox5.Size = new System.Drawing.Size(313, 313);
            //pictureBox5.Location = new Point(313, 313);
            pictureBox5.Visible = true;
            label1.Visible = true;
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
            }
            else
            {

            }
        }
        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox2.Location==pictureBox6.Location && pictureBox3.Location == pictureBox8.Location && 
                pictureBox4.Location==pictureBox7.Location && pictureBox5.Location==pictureBox9.Location)
            {
                pictureBox6.SendToBack();
                pictureBox7.SendToBack();
                pictureBox8.SendToBack();
                pictureBox9.SendToBack();
                MessageBox.Show("Пазл собран!");
            }
            else
            {
                
                label1.Text="Продолжайте собирать пазл";
            }
        }
        private void Puzzle_MouseMove(object sender, MouseEventArgs e)
        {
        }

    }
}
