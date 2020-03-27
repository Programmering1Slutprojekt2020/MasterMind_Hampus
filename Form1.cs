using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        int defaultSize = 40;
        int width, height;
        int activeIndex;
        int[,] clues = new int[4, 10];

        Random rnd = new Random();

        Color activeColor;
        Color[,] colorBoard = new Color[4, 10];

        Color gray = Color.DarkGray;
        Color red = Color.FromArgb(222, 32, 32);
        Color blue = Color.FromArgb(79, 87, 229);
        Color lightGreen = Color.FromArgb(57, 211, 25);
        Color yellow = Color.FromArgb(231, 228, 31);
        Color darkBlue = Color.FromArgb(18, 26, 34);
        Color darkGreen = Color.FromArgb(27, 91, 45);
        Color orange = Color.FromArgb(232, 126, 15);
        Color pink = Color.FromArgb(229, 117, 196);

        public Form1()
        {
            InitializeComponent();
            OnStart();

            width = panel1.Width;
            height = panel1.Height;

            btnRed.BackColor = red;
            btnBlue.BackColor = blue;
            btnLightGreen.BackColor = lightGreen;
            btnYellow.BackColor = yellow;
            btnDarkBlue.BackColor = darkBlue;
            btnDarkGreen.BackColor = darkGreen;
            btnOrange.BackColor = orange;
            btnPink.BackColor = pink;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //Rita colorBoard
            for (int yIndex = 9, yPos = 80; yIndex >= 0; yIndex--, yPos += defaultSize + 5)
            {
                for (int xIndex = 0, xPos = 30; xIndex < 4; xIndex++, xPos += defaultSize + 10)
                {
                    SolidBrush brush = new SolidBrush(colorBoard[xIndex, yIndex]);
                    g.FillRectangle(brush, xPos, yPos, defaultSize, defaultSize);
                }
            }
        }

        void OnStart()
        {
            activeIndex = 0;
            activeColor = red;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    colorBoard[x, y] = gray;
                }
            }

            panel1.Invalidate();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.X >= 30 && e.X <= 70)
            {
                colorBoard[0, activeIndex] = activeColor; ;
            }
            else if (e.X >= 80 && e.X <= 120)
            {
                colorBoard[1, activeIndex] = activeColor; ;
            }
            else if (e.X >= 130 && e.X <= 170)
            {
                colorBoard[2, activeIndex] = activeColor; ;
            }
            else if (e.X >= 180 && e.X <= 220)
            {
                colorBoard[3, activeIndex] = activeColor; ;
            }

            panel1.Invalidate();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            OnStart();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            activeColor = red;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            activeColor = blue;
        }

        private void btnLightGreen_Click(object sender, EventArgs e)
        {
            activeColor = lightGreen;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            activeColor = yellow;
        }

        private void btnDarkBlue_Click(object sender, EventArgs e)
        {
            activeColor = darkBlue;
        }

        private void btnDarkGreen_Click(object sender, EventArgs e)
        {
            activeColor = darkGreen;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            activeColor = orange;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            activeColor = pink;
        }

    }
}
