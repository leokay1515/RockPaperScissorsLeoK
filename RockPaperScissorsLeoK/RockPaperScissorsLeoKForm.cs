using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsLeoK
{
    public partial class frmRockPaperScissorsLeoK : Form
    {
        //Global Variables and Constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;
        int userChoice;
        int compChoice;
        int compRandom;
        Random randomNumberGenerator = new Random();

        public frmRockPaperScissorsLeoK()
        {
            InitializeComponent();

            //set all the buttons to be unchecked
            radRockUser.Checked = false;
            radPaperUser.Checked = false;
            radScissorsUser.Checked = false;
            radRockComputer.Checked = false;
            radPaperComputer.Checked = false;
            radScissorsComputer.Checked = false;

            //disable the computers buttons
            radRockComputer.Enabled = false;
            radPaperComputer.Enabled = false;
            radScissorsComputer.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //generate a random number and set compChoice to it
            compRandom = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            //if the user checks a certain box, set userChoice to its corresponding value
            if (radRockUser.Checked == true)
            {
                userChoice = ROCK;
            }
            else if (radPaperUser.Checked == true)
            {
                userChoice = PAPER;
            }
            else if (radScissorsUser.Checked == true)
            {
                userChoice = SCISSORS;
            }

            //set the random number to compchoice
            if (compRandom == ROCK)
            {
                compChoice = ROCK;
                radRockComputer.Checked = true;
            }
            else if (compRandom == PAPER)
            {
                compChoice = PAPER;
                radPaperComputer.Checked = true;
            }
            else
            {
                compChoice = SCISSORS;
                radScissorsComputer.Checked = true;
            }

            //check to see who won
            if (compChoice == ROCK)
            {
                if (userChoice == ROCK)
                {
                    lblResult.Text = "Tie";
                }
                else if (userChoice == PAPER)
                {
                    lblResult.Text = "You Win!";
                }
                else if (userChoice == SCISSORS)
                {
                    lblResult.Text = "You Lose";
                }
            }
            else
            {
                if (compChoice == PAPER)
                {
                    if (userChoice == ROCK)
                    {
                        lblResult.Text = "You Lose";
                    }
                    else if (userChoice == PAPER)
                    {
                        lblResult.Text = "Tie";
                    }
                    else if (userChoice == SCISSORS)
                    {
                        lblResult.Text = "You Win";
                    }
                }
                else
                {
                    if (compChoice == SCISSORS)
                    {
                        if (userChoice == ROCK)
                        {
                            lblResult.Text = "You Win";
                        }
                        else if (userChoice == PAPER)
                        {
                            lblResult.Text = "You Lose";
                        }
                        else if (userChoice == SCISSORS)
                        {
                            lblResult.Text = "Tie";
                        }
                    }
                }
            }
        }
    }
}
