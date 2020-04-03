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

        bool allowDuplicates = false;
        bool drawRightAnswer = false;

        Random rnd = new Random();

        Color activeColor;
        Color[] rightAnswer = new Color[4];
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
            if (drawRightAnswer)
            {
                for (int xIndex = 0, xPos = 30; xIndex < 4; xIndex++, xPos += defaultSize + 10)
                {
                    SolidBrush brush = new SolidBrush(rightAnswer[xIndex]);
                    g.FillRectangle(brush, xPos, 10, defaultSize, defaultSize);
                }
            }

        }
        void OnStart()
        {
            GenerateAnswer();

            activeIndex = 0;
            activeColor = red;

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    colorBoard[x, y] = gray;
                }
            }

            btnCheck.Location = new Point(228, 492);
            panel1.Invalidate();
        }

        void GenerateAnswer()
        {
            for (int i = 0; i < 4; i++)
            {
                Color tempColor = gray;
                do
                {
                    int colorIndex = rnd.Next(0, 7);
                    switch (colorIndex)
                    {
                        case 0: tempColor = red; break;
                        case 1: tempColor = blue; break;
                        case 2: tempColor = lightGreen; break;
                        case 3: tempColor = yellow; break;
                        case 4: tempColor = darkBlue; break;
                        case 5: tempColor = darkGreen; break;
                        case 6: tempColor = orange; break;
                        case 7: tempColor = pink; break;
                    }
                    if (!rightAnswer.Contains(tempColor)) break;

                }while(!allowDuplicates);
                rightAnswer[i] = tempColor;
            }
        }

        void EndGame()
        {
            drawRightAnswer = true;
            panel1.Invalidate();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (e.X >= 30 + i * (10 + defaultSize) && e.X <= 30 + i * (10 + defaultSize) + defaultSize) colorBoard[i, activeIndex] = activeColor;
            }

            panel1.Invalidate();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            OnStart();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (activeIndex < 9)
            {
                activeIndex++;
                btnCheck.Location = new Point(btnCheck.Location.X, btnCheck.Location.Y - (defaultSize + 5));
            }
            else EndGame();
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
