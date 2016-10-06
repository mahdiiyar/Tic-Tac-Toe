/* Name: MKhomeiriAssignment2
 * Creator: Mohammad Khomeiri
 * Date: Oct 5rd 2015
 * 
 * Revation History: OCT 1st adding lable and picture boxes.
 *                   OCT 2nd adding array and checkit method.
 *                   OCT 5rd adding counter of wins and etc and finishing Program.
 * 
 * 
 * Summery: Program that people can play tic tac toe.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKhomeiriAssignment2
{
    /// <summary>
    /// Tic Tac Toe Form
    /// </summary>
    public partial class Form1 : Form
    {
        string game = "x";
        public string[] place = new string[9] 
        { "", "", "", "", "", "", "", "", "" };
        string error = "";
        int xWin = 0;
        int oWin = 0;

        /// <summary>
        /// Constructor for the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Choose that X turn or O turn for upper left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUpperLeft_Click(object sender, EventArgs e)
        {

            if (game == "x")
            {
                place[0] = "x";
                pbxUpperLeft.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[0] = "o";
                pbxUpperLeft.Image = Properties.Resources.O;
                game = "x";
            }
            lblUpperLeft.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for upper center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUpperCenter_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[1] = "x";
                pbxUpperCenter.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[1] = "o";
                pbxUpperCenter.Image = Properties.Resources.O;
                game = "x";
            }
            lblUpperCenter.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for upper right.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblUpperRight_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[2] = "x";
                pbxUpperRight.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[2] = "o";
                pbxUpperRight.Image = Properties.Resources.O;
                game = "x";
            }
            lblUpperRight.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for middle left.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMiddleLeft_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[3] = "x";
                pbxMiddleLeft.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[3] = "o";
                pbxMiddleLeft.Image = Properties.Resources.O;
                game = "x";
            }
            lblMiddleLeft.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for middle center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMiddleCenter_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[4] = "x";
                pbxMiddleCenter.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[4] = "o";
                pbxMiddleCenter.Image = Properties.Resources.O;
                game = "x";
            }
            lblMiddleCenter.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for middle center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMiddleRight_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[5] = "x";
                pbxMiddleRight.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[5] = "o";
                pbxMiddleRight.Image = Properties.Resources.O;
                game = "x";
            }
            lblMiddleRight.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for lower left.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLowerLeft_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[6] = "x";
                pbxLowerLeft.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[6] = "o";
                pbxLowerLeft.Image = Properties.Resources.O;
                game = "x";
            }
            lblLowerLeft.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for lower center.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLowerCenter_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[7] = "x";
                pbxLowerCenter.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[7] = "o";
                pbxLowerCenter.Image = Properties.Resources.O;
                game = "x";
            }
            lblLowerCenter.Visible = false;
            checkit();
        }

        /// <summary>
        /// Choose that X turn or O turn for middle right.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLowerRight_Click(object sender, EventArgs e)
        {
            if (game == "x")
            {
                place[8] = "x";
                pbxLowerRight.Image = Properties.Resources.X1;
                game = "o";
            }
            else
            {
                place[8] = "o";
                pbxLowerRight.Image = Properties.Resources.O;
                game = "x";
            }
            lblLowerRight.Visible = false;
            checkit();
        }

        /// <summary>
        /// check is x wins or o or its tie and how many times they won.
        /// </summary>
        private void checkit()
        {
            error = "";
            int empty = 1;
            if (place[0] == "x" && place[1] == "x" && place[2] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[3] == "x" && place[4] == "x" && place[5] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[6] == "x" && place[7] == "x" && place[8] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[0] == "x" && place[3] == "x" && place[6] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[1] == "x" && place[4] == "x" && place[7] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[2] == "x" && place[5] == "x" && place[8] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[0] == "x" && place[4] == "x" && place[8] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[2] == "x" && place[4] == "x" && place[6] == "x")
            {
                error += "X Wins";
                xWin++;
            }
            else if (place[0] == "o" && place[1] == "o" && place[2] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[3] == "o" && place[4] == "o" && place[5] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[6] == "o" && place[7] == "o" && place[8] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[0] == "o" && place[3] == "o" && place[6] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[1] == "o" && place[4] == "o" && place[7] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[2] == "o" && place[5] == "o" && place[8] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[0] == "o" && place[4] == "o" && place[8] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            else if (place[2] == "o" && place[4] == "o" && place[6] == "o")
            {
                error += "O Wins";
                oWin++;
            }
            //tie

            else if (place[0].Length >= empty && place[1].Length >= empty 
                && place[2].Length >= empty 
                && place[3].Length >= empty && place[4].Length >= empty
                && place[5].Length >= empty && place[6].Length >= empty 
                && place[7].Length >= empty && place[8].Length >= empty)
            {
                error += "Tie Game";
            }
            //how many times x won.
            if (error == "X Wins")
            {
                for (int i = 0; i <= xWin; i++)
                {
                    lblXWinCounter.Text = xWin.ToString();
                }
            }
            ////how many times o won.
            else if (error == "O Wins")
            {
                for (int i = 0; i <= oWin; i++)
                {
                    lblOWinCounter.Text = oWin.ToString();
                }
            }
            //error
            if (error != "")
            {
                lblError.Text = error;
                error = "";
                btnContinue.Visible = true;
                lblError.Visible = true;
                lblUpperLeft.Enabled = false;
                lblUpperCenter.Enabled = false;
                lblUpperRight.Enabled = false;
                lblMiddleLeft.Enabled = false;
                lblMiddleCenter.Enabled = false;
                lblMiddleRight.Enabled = false;
                lblLowerLeft.Enabled = false;
                lblLowerCenter.Enabled = false;
                lblLowerRight.Enabled = false;
            }
        }

        /// <summary>
        /// countinue and play again button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinue_Click(object sender, EventArgs e)
        {

            for (int i = 0; i <= 8; i++)
            {
                place[i] = "";
            }
            game = "x";
            btnContinue.Visible = false;
            lblUpperLeft.Visible = true;
            lblUpperCenter.Visible = true;
            lblUpperRight.Visible = true;
            lblMiddleLeft.Visible = true;
            lblMiddleCenter.Visible = true;
            lblMiddleRight.Visible = true;
            lblLowerLeft.Visible = true;
            lblLowerCenter.Visible = true;
            lblLowerRight.Visible = true;
            lblUpperLeft.Enabled = true;
            lblUpperCenter.Enabled = true;
            lblUpperRight.Enabled = true;
            lblMiddleLeft.Enabled = true;
            lblMiddleCenter.Enabled = true;
            lblMiddleRight.Enabled = true;
            lblLowerLeft.Enabled = true;
            lblLowerCenter.Enabled = true;
            lblLowerRight.Enabled = true;
            pbxUpperLeft.Image = null;
            pbxUpperCenter.Image = null;
            pbxUpperRight.Image = null;
            pbxMiddleLeft.Image = null;
            pbxMiddleCenter.Image = null;
            pbxMiddleRight.Image = null;
            pbxLowerLeft.Image = null;
            pbxLowerCenter.Image = null;
            pbxLowerRight.Image = null;

            error = "";
            lblError.Text = "";
            lblError.Visible = false;
            btnContinue.Visible = false;
        }
    }
}
