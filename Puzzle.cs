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
        public Puzzle()
        {
            InitializeComponent();
        }        

        private void Puzzle_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(button1, true);
            ControlExtension.Draggable(pictureBox1, true);
            ControlExtension.Draggable(pictureBox2, true);
            ControlExtension.Draggable(pictureBox3, true);
            ControlExtension.Draggable(pictureBox4, true);
            ControlExtension.Draggable(pictureBox5, true);
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Size= new System.Drawing.Size(313, 313);
            pictureBox2.Location =new Point (0, 0);
            pictureBox2.Visible = true;
            pictureBox3.Size = new System.Drawing.Size(313, 313);
            pictureBox3.Location = new Point(313, 0);
            pictureBox3.Visible = true;
            pictureBox4.Size = new System.Drawing.Size(313, 313);
            pictureBox4.Location = new Point(0, 313);
            pictureBox4.Visible = true;
            pictureBox5.Size = new System.Drawing.Size(313, 313);
            pictureBox5.Location = new Point(313, 313);
            pictureBox5.Visible = true;
        }

        private void Puzzle_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < pictureBox2.X + pictureBox2.Width) && (e.X > pictureBox2.X))
            {
                if ((e.Y < pictureBox2.Y + pictureBox2.Height) && (e.Y > pictureBox2.Y))
                {
                    pictureBox2Clicked = true;
                    pictureBox2X = e.X - pictureBox2.X;
                    pictureBox2Y = e.Y - pictureBox2.Y;
                }
            }
            if ((e.X < pictureBox3.X + pictureBox3.Width) && (e.X > pictureBox3.X))
            {
                if ((e.Y < pictureBox3.Y + pictureBox3.Height) && (e.Y > pictureBox3.Y))
                {
                    pictureBox3Clicked = true;
                    pictureBox3X = e.X - pictureBox3.X;
                    pictureBox3Y = e.Y - pictureBox3.Y;
                }
            }
            if ((e.X < pictureBox4.X + pictureBox4.Width) && (e.X > pictureBox4.X))
            {
                if ((e.Y < pictureBox4.Y + pictureBox4.Height) && (e.Y > pictureBox4.Y))
                {
                    pictureBox4Clicked = true;
                    pictureBox4X = e.X - pictureBox4.X;
                    pictureBox4Y = e.Y - pictureBox4.Y;
                }
            }
            if ((e.X < pictureBox5.X + pictureBox5.Width) && (e.X > pictureBox5.X))
            {
                if ((e.Y < pictureBox5.Y + pictureBox5.Height) && (e.Y > pictureBox5.Y))
                {
                    pictureBox5Clicked = true;
                    pictureBox5X = e.X - pictureBox5.X;
                    pictureBox5Y = e.Y - pictureBox5.Y;
                }
            }
        }
        private void Puzzle_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2Clicked = false;
            pictureBox3Clicked = false;
            pictureBox4Clicked = false;
            pictureBox5Clicked = false;
        }
        private void Puzzle_MouseMove(object sender, MouseEventArgs e)
        {

        }

    }
}
