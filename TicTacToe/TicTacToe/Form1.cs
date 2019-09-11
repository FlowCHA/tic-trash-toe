using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Player X starts the game.";
        }
        Controller controls = new Controller();
        

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(0))
            {
                label1.Text = button1.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button1.Text = "X";
                    controls.setSpotMark(0, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button1.Text = "O";
                    controls.setSpotMark(0, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(0, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if(controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(1))
            {
                label1.Text = button2.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button2.Text = "X";
                    controls.setSpotMark(1, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button2.Text = "O";
                    controls.setSpotMark(1, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(1, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(2))
            {
                label1.Text = button3.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button3.Text = "X";
                    controls.setSpotMark(2, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button3.Text = "O";
                    controls.setSpotMark(2, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(2, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(3))
            {
                label1.Text = button4.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button4.Text = "X";
                    controls.setSpotMark(3, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button4.Text = "O";
                    controls.setSpotMark(3, 2);
                }

                controls.updateCounter();
                controls.setButtonClicked(3, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(4))
            {
                label1.Text = button5.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button5.Text = "X";
                    controls.setSpotMark(4, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button5.Text = "O";
                    controls.setSpotMark(4, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(4, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if(!controls.getButtonClicked(5))
            {
                label1.Text = button6.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button6.Text = "X";
                    controls.setSpotMark(5, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button6.Text = "O";
                    controls.setSpotMark(5, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(5, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(6))
            {
                label1.Text = button7.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button7.Text = "X";
                    controls.setSpotMark(6, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button7.Text = "O";
                    controls.setSpotMark(6, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(6, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(7))
            {
                label1.Text = button8.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button8.Text = "X";
                    controls.setSpotMark(7, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button8.Text = "O";
                    controls.setSpotMark(7, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(7, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (!controls.getButtonClicked(8))
            {
                label1.Text = button9.Name + " clicked.";
                if (controls.getCounter() % 2 == 1)
                {
                    button9.Text = "X";
                    controls.setSpotMark(8, 1);
                }
                else if (controls.getCounter() % 2 == 0)
                {
                    button9.Text = "O";
                    controls.setSpotMark(8, 2);
                }
                controls.updateCounter();
                controls.setButtonClicked(8, true);
            }
            else
            {
                label1.Text = "You can't click that button.";
            }

            if (controls.checkWin())
            {
                if (controls.getCounter() % 2 == 0)
                {
                    label1.Text = "Player X wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }
                if (controls.getCounter() % 2 == 1)
                {
                    label1.Text = "Player O wins.";
                    for (int i = 0; i < 9; i++)
                        controls.setButtonClicked(i, true);
                }

            }
        }
    }
}
