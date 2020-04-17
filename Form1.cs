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
        int activeIndex = 0;
        int scorePoints = 0;
        int[,] clues = new int[4, 10];

        bool allowDoubles = false;
        bool drawRightAnswer;
        bool win;
        bool highlightMissingBox;

        Random rnd = new Random();

        Color activeColor;
        Color[] rightAnswer = new Color[4];
        Color[,] colorBoard = new Color[4, 10];

        Color gray = Color.LightGray;
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

            cbxAllowDoubles.Checked = false;
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
            //Rita Clues
            for (int yIndex = 9, yPos = 82; yIndex >= 0; yIndex--, yPos += defaultSize + 5)
            {
                for (int i = 0 ; i < 2; i++)
                {
                    int yOffset = defaultSize / 2;
                    for (int xIndex = 0 + 2*i, xPos = 300; xIndex < 2 + 2*i; xIndex++, xPos += defaultSize / 2)
                    {
                        SolidBrush brush;
                        if (clues[xIndex, yIndex] == 2)
                        {
                            brush = new SolidBrush(Color.Black);
                        }
                        else if (clues[xIndex, yIndex] == 1)
                        {
                            brush = new SolidBrush(Color.Gray);
                        }
                        else
                        {
                            brush = new SolidBrush(Color.LightGray);
                        }
                        g.FillRectangle(brush, xPos, yPos + yOffset * i, defaultSize / 2 - 2, defaultSize / 2 - 2);
                    }
                }

            }
            if (drawRightAnswer)
            {
                Color winColor = Color.IndianRed;
                string winText = "   Wrong\nCombination!";

                for (int xIndex = 0, xPos = 30; xIndex < 4; xIndex++, xPos += defaultSize + 10)
                {
                    SolidBrush brush = new SolidBrush(rightAnswer[xIndex]);
                    g.FillRectangle(brush, xPos, 10, defaultSize, defaultSize);
                }

                if (win)
                {
                    winColor = Color.DarkSeaGreen;
                    winText = "  Correct\nCombination!";
                }
                SolidBrush winBrush = new SolidBrush(winColor);
                g.FillRectangle(winBrush, 110, 200, 180, 80);

                Font font = new Font("Consolas", 18);
                SolidBrush winTextBrush = new SolidBrush(Color.White);
                g.DrawString(winText, font, winTextBrush, 118, 210);
            }
            if (highlightMissingBox)
            {
                Pen highlighter = new Pen(Color.Black);
                highlighter.Width = 3;
                for (int i = 0; i < 4; i++)
                {
                    if(colorBoard[i,activeIndex] == gray)
                    {
                        g.DrawRectangle(highlighter, 30 + i * (defaultSize + 10), 485 - activeIndex * (defaultSize + 5), defaultSize, defaultSize);
                    }
                }
            }

        }
        void OnStart()
        {
            allowDoubles = cbxAllowDoubles.Checked;
            drawRightAnswer = false;
            btnCheck.Enabled = true;
            highlightMissingBox = false;
            win = false;
            activeIndex = 0;
            activeColor = red;
            GenerateAnswer();

            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    colorBoard[x, y] = gray;
                }
            }

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    clues[x, y] = 0;
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

                } while (!allowDoubles);
                rightAnswer[i] = tempColor;
            }
        }

        void TestIfRight()
        {
            List<int> tempClues = new List<int>();
            List<int> indexMemory = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    if (colorBoard[i,activeIndex] == rightAnswer[k] && !indexMemory.Contains(k))
                    {
                        if (i == k) tempClues.Add(2);
                        else tempClues.Add(1);
                        indexMemory.Add(k);
                        break;
                    }
                }
            }
            tempClues.Sort();
            tempClues.Reverse();
            for (int i = 0; i < tempClues.Count(); i++)
            {
                clues[i, activeIndex] = tempClues[i];
            }
            if (tempClues.Sum() == 8)
            {
                win = true;
                scorePoints++;
                EndGame();
            }
        }

        void EndGame()
        {
            drawRightAnswer = true;
            lblScore.Text = "Score: " + scorePoints;
            btnCheck.Enabled = false;
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
            for (int i = 0; i < 4; i++)
            {
                if (colorBoard[i, activeIndex] == gray)
                {
                    highlightMissingBox = true;
                    panel1.Invalidate();
                    return;
                }
            }
            TestIfRight();
            if (activeIndex < 9)
            {
                activeIndex++;
                btnCheck.Location = new Point(btnCheck.Location.X, btnCheck.Location.Y - (defaultSize + 5));
            }
            else EndGame();
            highlightMissingBox = false;
            panel1.Invalidate();
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