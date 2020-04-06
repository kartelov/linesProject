using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startX = canvas.Width / 2;
            startY = canvas.Height / 2;
        }
        Graphics g = null; //e.Graphics;
        Pen p = new Pen(Color.Red, 2);

        //int ceneterX, centerY;
        int startX, startY;
        int endX, endY;
        
        int angle = 0;
        int length = 0;
        int increment = 0;
        int lines = 0;
        int aincr = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


       
        private void button1_Click(object sender, EventArgs e)
        {
            lines = Int32.Parse(textBox1.Text);
            angle = Int32.Parse(textBox2.Text);
            length = Int32.Parse(textBox3.Text);
            increment = Int32.Parse(textBox4.Text);
            aincr = Int32.Parse(textBox5.Text);

            startX = canvas.Width / 2;
            startY = canvas.Height / 2;

            canvas.Refresh();   

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
     

            g = canvas.CreateGraphics(); //
            int len = length;
            int ang = angle;

            for (int i=0; i< lines; i++)
            {
                len += increment;
                ang += angle;
                aincr += aincr;
                //ang -= aincr;
                endX = (int)(startX + Math.Cos(ang * 0.0174532925) * len);
                endY = (int)(startY + Math.Sin(ang * 0.0174532925) * len);
                

                g.DrawLine(p, startX, startY, endX, endY);

                startX = endX;
                startY = endY;
            }
            


        }
    }
}
