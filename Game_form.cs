using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_Toe
{
    public partial class Game : Form
    {
        //checks if the current player will be X or O 
        Boolean checker;  

        //winning counter 
        int plusone;

        //count filled Cells
        int filledCells = 0;
        public Game(string p1, string p2)
        {
            InitializeComponent();
            label1.Text = p1 + " X :";
            label2.Text = p2 + " O :";
        }

        void Enable_false()
        {
            btnTic1.Enabled = false;
            btnTic2.Enabled = false;
            btnTic3.Enabled = false;
            btnTic4.Enabled = false;
            btnTic5.Enabled = false;
            btnTic6.Enabled = false;
            btnTic7.Enabled = false;
            btnTic8.Enabled = false;
            btnTic9.Enabled = false;
        }
        void Enable_true()
        {
            btnTic1.Enabled = true;
            btnTic2.Enabled = true;
            btnTic3.Enabled = true;
            btnTic4.Enabled = true;
            btnTic5.Enabled = true;
            btnTic6.Enabled = true;
            btnTic7.Enabled = true;
            btnTic8.Enabled = true;
            btnTic9.Enabled = true;
        }
        void btnsTextClear()
        {
            btnTic1.Text = "";
            btnTic2.Text = "";
            btnTic3.Text = "";
            btnTic4.Text = "";
            btnTic5.Text = "";
            btnTic6.Text = "";
            btnTic7.Text = "";
            btnTic8.Text = "";
            btnTic9.Text = "";
        }

        // main game play 
        void score()
        {
            
                 if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic1, btnTic2, btnTic3 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic1, btnTic4, btnTic7 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic1, btnTic5, btnTic9 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic3, btnTic5, btnTic7 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic2, btnTic5, btnTic8 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic3, btnTic6, btnTic9 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic4, btnTic5, btnTic6 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (evaluteButtons(checker ? "X" : "O", new List<Button>() { btnTic7, btnTic8, btnTic9 }, checker ? lblplayrX : lblplayrO))
            { playerWin(checker); }
            else if (filledCells == 9)
            {
                MessageBox.Show("It's a draw!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Enable_false();
            }
        }
         void playerWin(bool checker)
        {
            string player = checker ? "X" : "O";
            MessageBox.Show("The winner is player " + player, "Tic Tac Toi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Label targetLbl = checker ? lblplayrX : lblplayrO;
            plusone = int.Parse(targetLbl.Text);
            targetLbl.Text = Convert.ToString(plusone + 1);
            Enable_false();

        }

        //evaluates current game status
        private bool evaluteButtons(string player, List<Button> testSet, Label targetLbl) {
            if (testSet[0].Text == player && testSet[1].Text == player && testSet[2].Text == player)
            {
                return true;
            }
            return false;
        }
   
        private void onBtnClick(Button btn)
        {
            if (checker == false)
            {
                btn.Text = "X";
                checker = true;
            }
            else
            {
                btn.Text = "O";
                checker = false;
            }
            filledCells++;
            score();
            btn.Enabled = false;
        }
       
        //Button 1 event handler
        private void btnTic1_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic1);
        }

        //Button 2 event handler
        private void btnTic2_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic2);
        }

        //Button 3 event handler
        private void btnTic3_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic3);

        }

        //Button 4 event handler
        private void btnTic4_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic4);


        }

        //Button 5 event handler
        private void btnTic5_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic5);

        }

        //Button 6 event handler
        private void btnTic6_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic6);

        }

        //Button 7 event handler
        private void btnTic7_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic7);
        }

        //Button 8 event handler
        private void btnTic8_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic8);
        }

        //Button 9 event handler
        private void btnTic9_Click(object sender, EventArgs e)
        {
            onBtnClick(btnTic9);
        }

        // new game button event handler
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                filledCells = 0;
                Enable_true();
                btnsTextClear();
                

                btnNewGame.Enabled = true;

                lblplayrX.Text = "0";
                lblplayrO.Text = "0";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // reset button event handler
        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                filledCells = 0;
                Enable_true();
                btnsTextClear();    

                btnNewGame.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // exit button event handler
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirm if you want to exit", "Tic Tac Toe",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}