using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Graphics_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Create a font
            Font font = new Font("Comic Sans MS", 30);
            //Create different colour brushes
            SolidBrush solidBrushRed = new SolidBrush(Color.Red);
            SolidBrush solidBrushGreen = new SolidBrush(Color.Green);
            SolidBrush solidBrushPurple = new SolidBrush(Color.Purple);
            // Create different colour pens 
            Pen penBlue = new Pen(Color.Blue, 5);
            Pen penYellow = new Pen(Color.Yellow, 5);
            Pen penPurple = new Pen(Color.Purple, 5);
            // Bring a picture in
            string path = Application.StartupPath + @"\stickman-direction.jpg";
            Image stickman = Image.FromFile(path);


            // Draw text using instantiated variables
            graphics.DrawString("Hello C#", font, solidBrushRed, 150, 80);
            // Draw text using in-line variables
            graphics.DrawString("Hello C#", new Font("Times New Roman", 30), new SolidBrush(Color.Green), 150, 150);
            // Draw a line using the pen
            graphics.DrawLine(penBlue, 0, 0, Width, Height);
            // Draw a hollow rectangle
            graphics.DrawRectangle(penYellow, 10, 200, 60, 100);
            // Draw filled rectangle
            graphics.FillRectangle(solidBrushPurple, 10, 56, 79, 23);
            // Draw an hollow circle
            graphics.DrawEllipse(penPurple, 200, 200, 46, 46);
            // Draw a filled circle
            graphics.FillEllipse(solidBrushGreen, 300, 300, 46, 46);
            // Draw the Image and rescale him
            graphics.DrawImage(stickman, 50, 50, 60, 60);

            //Challenge, draw an X across the screen
            graphics.DrawLine(penYellow, 0f, 0f, ClientRectangle.Width,ClientRectangle.Height);
            graphics.DrawLine(penYellow, ClientRectangle.Width, 0f, 0f, ClientRectangle.Height);

            // Challenge, draw a line vertically down from the middle and a line horizontally from the middle.
            graphics.DrawLine(penPurple, Width / 2, ClientRectangle.Height, ClientRectangle.Width, Height /2);


        }
    }
}
