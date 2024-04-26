using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TicTacToe
{
    public partial class Form1 : Form
    {
        //fields
        bool turn = true, b1 = true, b2 = true, b3 = true, b4 = true, b5 = true,
            b6 = true, b7 = true, b8 = true, b9 = true;
        BoardChecker bc = new BoardChecker();
        double x = 0, o = 0, game = 0;

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resetting images on buttons
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;

            //resetting variables
            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;
            b9 = true;
            turn = true;

            //resetting text
            resultBox.Text = "";
            turnBox.Text = "X";
            recordLabel.Text = "Records:";

            //resetting scores
            x = 0;
            o = 0;
            game = 0;

            //clearing
            bc.Clear();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //resetting images on buttons
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;

            //resetting variables
            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;
            b9 = true;
            turn = true;

            //resetting text
            resultBox.Text = "";
            turnBox.Text = "X";

            //clearing
            bc.Clear();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!b1)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button1.Width, button1.Height);
                button1.Image = bmp;
                button1.Update();
                bc.Accumulate(0, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button1.Width, button1.Height);
                button1.Image = bmp2;
                button1.Update();
                bc.Accumulate(0, "O");
            }

            //checking for win
            if(bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if(bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if(bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b1 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!b2)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button2.Width, button2.Height);
                button2.Image = bmp;
                button2.Update();
                bc.Accumulate(1, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button2.Width, button2.Height);
                button2.Image = bmp2;
                button2.Update();
                bc.Accumulate(1, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b2 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!b3)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button3.Width, button3.Height);
                button3.Image = bmp;
                button3.Update();
                bc.Accumulate(2, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button3.Width, button3.Height);
                button3.Image = bmp2;
                button3.Update();
                bc.Accumulate(2, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b3 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!b4)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button4.Width, button4.Height);
                button4.Image = bmp;
                button4.Update();
                bc.Accumulate(3, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button4.Width, button4.Height);
                button4.Image = bmp2;
                button4.Update();
                bc.Accumulate(3, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b4 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!b5)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button5.Width, button5.Height);
                button5.Image = bmp;
                button5.Update();
                bc.Accumulate(4, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button5.Width, button5.Height);
                button5.Image = bmp2;
                button5.Update();
                bc.Accumulate(4, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b5 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!b6)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button6.Width, button6.Height);
                button6.Image = bmp;
                button6.Update();
                bc.Accumulate(5, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button6.Width, button6.Height);
                button6.Image = bmp2;
                button6.Update();
                bc.Accumulate(5, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b6 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!b7)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button7.Width, button7.Height);
                button7.Image = bmp;
                button7.Update();
                bc.Accumulate(6, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button7.Width, button7.Height);
                button7.Image = bmp2;
                button7.Update();
                bc.Accumulate(6, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b7 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!b8)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button8.Width, button8.Height);
                button8.Image = bmp;
                button8.Update();
                bc.Accumulate(7, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button8.Width, button8.Height);
                button8.Image = bmp2;
                button8.Update();
                bc.Accumulate(7, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b8 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!b9)
                return;

            //player X
            if (turn)
            {
                Bitmap bmp = new Bitmap(Properties.Resources.logo,
                    button9.Width, button9.Height);
                button9.Image = bmp;
                button9.Update();
                bc.Accumulate(8, "X");
            }

            //player O
            else
            {
                Bitmap bmp2 = new Bitmap(Properties.Resources.cat,
                    button9.Width, button9.Height);
                button9.Image = bmp2;
                button9.Update();
                bc.Accumulate(8, "O");
            }

            //checking for win
            if (bc.Xwin())
            {
                x++;
                game++;
                resultBox.Text = "X wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Owin())
            {
                o++;
                game++;
                resultBox.Text = "O wins!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }
            if (bc.Tie())
            {
                game++;
                resultBox.Text = "Tie game!";
                recordLabel.Text = "Records:" + Environment.NewLine + "X winning: " +
                    (x / game).ToString("0.##") + Environment.NewLine + "O winning: " +
                    (o / game).ToString("0.##");
            }

            //disallowing future use of this button and switching turn
            b9 = false;
            if (turn)
            {
                turn = false;
                turnBox.Text = "O";
            }
            else
            {
                turn = true;
                turnBox.Text = "X";
            }
        }
    }
}
