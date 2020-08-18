using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        public void ValidNum(string InputY, string InputX)
        {
            int NumYorN = - 1;
            
            
            if (int.TryParse(InputY, out NumYorN) && int.TryParse(InputX, out NumYorN))
            {
                UserY = Convert.ToInt32(InputY) - 1;
                UserX = Convert.ToInt32(InputX) - 1;
                
            }
            else
            {
                
                System.Windows.Forms.MessageBox.Show("Invalid Input");
                txtbXpos.Text = "";
                txtbYpos.Text = "";
            }
            
        }

        //Question 2

        public void StartGame(int xMin, int xMax, int yMin, int yMax, int MineNum)
        {
            wMin = xMin;
            wMax = xMax;
            hMin = yMin;
            hMax = yMax;
            MineNo = MineNum;

            Height = RandomRoll(hMin, hMax);
            Width = RandomRoll(wMin, wMax);
            //System.Windows.Forms.MessageBox.Show(Height + "\n" + Width);

            MineField = new char[Height, Width];
            PlayerGuess = new char[Height, Width];

            Score = 0;
            Actions = Height * Width;

            Initialise(Height, Width);
        }

        //Question 3

        //Global Var
        public static int wMin, wMax, hMin, hMax, MineNo, Width, Height, UserY, UserX;
        public char[,] MineField;
        public char[,] PlayerGuess;
        public Random Rng = new Random();
        public int Actions;
        public int Score;

        public void Initialise(int Height, int Width)
        {
            btnTest.Visible = false;
            btnTest.Enabled = false;

            lblScore.Text = "Score: " + Score;
            lblActions.Text = "Actions Remaining: " + Actions;

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    PlayerGuess[y, x] = '.';
                }
            }

            RefreshMap();
            GivemMines(MineNo);

        }

        //Question 4
       
        public void RefreshMap() // Redraw
        {
            lblScore.Text = "Score: " + Score;
            lblActions.Text = "Actions Remaining: " + Actions;
            string Output = "";

            for (int y = 0; y < Height; y++) 
            {
                for (int x = 0; x < Width; x++) 
                {
                    if (PlayerGuess[y, x] == 'F')
                    {
                        Output += "F";
                    }
                    else
                    {
                        Output += PlayerGuess[y, x];
                    }
                    
                }
                Output += "\n";
            }

            lblMineField.Text = Output;
        }

        public void Flagged()
        {
            int Count = 0;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (PlayerGuess[y, x] == 'F')
                    {
                        Count++;
                    }
                }
            }

            if (Count == MineNo)
            {
                GameOver(false);
            }
        }

        public int RandomRoll(int Min, int Max)
        {
            int Value = Rng.Next(Min, Max + 1);
            return Value;
        }

        public void GivemMines(int NumMines) //FillMapWithMines
        {
            int xPos, yPos;
            xPos = RandomRoll(0, Width - 1);
            yPos = RandomRoll(0, Height - 1);

            for (int i = 0; i < NumMines; i++)
            {
                while (MineField[yPos, xPos] == 'x')
                {
                    xPos = RandomRoll(0, Width - 1);
                    yPos = RandomRoll(0, Height - 1);
                }
                PlantMine(yPos, xPos);
            }
            RefreshMap();
        }

        public void PlantMine(int yPos, int xPos) //PlaceMines
        {
            MineField[yPos, xPos] = 'x';
        }

        public void Guess(int yPos, int xPos)
        {
            
            if (Score <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Score Too Low");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Guesses use up 1 point");
                Score = Score - 1;
                Actions = Actions - 1;
                
                if (MineField[yPos, xPos] == 'x')
                {
                    PlayerGuess[yPos, xPos] = 'F';
                    RefreshMap();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("You have incorrectly flagged a mine");
                }
                Flagged();
            }
        }

        //Question 5

        public bool TheReveal(int yPos, int xPos)
        {
            bool Flag = false;
            Actions = Actions - 1;
            int ThePlay;
            ThePlay = Minesweep(yPos, xPos);
            switch (ThePlay)
            {
                case 0:
                    PlayerGuess[yPos, xPos] = '0';
                    RefreshMap();
                    Flag = false;
                    break;
                case 1:
                    PlayerGuess[yPos, xPos] = '1';
                    RefreshMap();
                    Flag = false;
                    break;
                case 2:
                    PlayerGuess[yPos, xPos] = '2';
                    RefreshMap();
                    Flag = false;
                    break;
                case 3:
                    PlayerGuess[yPos, xPos] = '3';
                    RefreshMap();
                    Flag = false;
                    break;
                case 4:
                    PlayerGuess[yPos, xPos] = '4';
                    RefreshMap();
                    Flag = false;
                    break;
                case 5:
                    PlayerGuess[yPos, xPos] = '5';
                    RefreshMap();
                    Flag = false;
                    break;
                case 6:
                    PlayerGuess[yPos, xPos] = '6';
                    RefreshMap();
                    Flag = false;
                    break;
                case 7:
                    PlayerGuess[yPos, xPos] = '7';
                    RefreshMap();
                    Flag = false;
                    break;
                case 8:
                    PlayerGuess[yPos, xPos] = '8';
                    RefreshMap();
                    Flag = false;
                    break;
                case 9:                    
                    Flag = true;
                    break;
            }
            return Flag;
        }
        public int Minesweep(int yPos,int xPos)
        {
            //string talk = "";
            int yTest,xTest;
            int ThePlay = 0;
            if (MineField[yPos, xPos] == 'x')
            {
                ThePlay = 9;
            }
            else
            {
                for (int i = 1; i <= 8; i++)
                {
                    switch (i)
                    {
                        case 1:
                            xTest = 0;
                            xTest = xPos - 1;
                            if (xTest >= 0 && xTest < Width)
                            {
                                if (MineField[yPos, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "Case 1 = " + yPos + ":" + xTest;
                                }
                            }
                            break;
                        case 2:
                            xTest = 0;
                            xTest = xPos + 1;
                            if (xTest >= 0 && xTest < Width )
                            {
                                if (MineField[yPos, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 2 = " + yPos + ":" + xTest;
                                }
                            }
                            break;
                        case 3:
                            yTest = 0;
                            yTest = yPos - 1;
                            if (yTest >= 0 && yTest < Height)
                            {
                                if (MineField[yTest, xPos] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 3 = " + yTest + ":" + xPos;
                                }
                            }
                            break;
                        case 4:
                            yTest = 0;
                            yTest = yPos + 1;
                            if (yTest >= 0 && yTest < Height )
                            {
                                if (MineField[yTest, xPos] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 4 = " + yTest + ":" + xPos;
                                }
                            }
                            break;
                        case 5:
                            xTest = 0;
                            yTest = 0;
                            xTest = xPos + 1;
                            yTest = yPos + 1;
                            
                            if (yTest >= 0 && yTest < Height && xTest >= 0 && xTest < Width)
                            {
                                if (MineField[yTest, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 5 = " + yTest + ":" + xTest;
                                }
                            }
                            break;
                        case 6:
                            xTest = 0;
                            xTest = xPos - 1;
                            yTest = 0;
                            yTest = yPos - 1;

                            if (yTest >= 0 && yTest < Height && xTest >= 0 && xTest < Width)
                            {
                                if (MineField[yTest, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 6 = " + yTest + ":" + xTest;
                                }
                            }
                            break;
                        case 7:
                            xTest = 0;
                            xTest = xPos - 1;
                            yTest = 0;
                            yTest = yPos + 1;

                            if (yTest >= 0 && yTest < Height && xTest >= 0 && xTest < Width)
                            {
                                if (MineField[yTest, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 7 = " + yTest + ":" + xTest;
                                }
                            }
                            break;
                        case 8:
                            xTest = 0;
                            yTest = 0;
                            xTest = xPos + 1;
                            yTest = yPos - 1;

                            if (yTest >= 0 && yTest < Height && xTest >= 0 && xTest < Width)
                            {
                                if (MineField[yTest, xTest] == 'x')
                                {
                                    ThePlay++;
                                    Score++;
                                    //talk += "\n Case 8 = " + yTest + ":" + xTest;
                                }
                            }
                            break;
                    }
                }
            }
            //System.Windows.Forms.MessageBox.Show(talk);
            return ThePlay;
        }

        public void GameOver(bool WinOrLose)
        {
            switch (WinOrLose)
            {
                case false:
                    System.Windows.Forms.MessageBox.Show("Winner");
                    btnReveal.Enabled = false;
                    btnFlag.Enabled = false;
                    break;
                case true:
                    System.Windows.Forms.MessageBox.Show("Game Over");
                    btnReveal.Enabled = false;
                    btnFlag.Enabled = false;
                    ThaWay();
                    break;
            }
            //System.Windows.Forms.MessageBox.Show("Winner");
        }

        public void ThaWay()
        {
            
            string Output = "";

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (MineField[y, x] == 'x')
                    {
                        if (PlayerGuess[y, x] == 'F')
                        {
                            Output += PlayerGuess[y, x];
                        }
                        else
                        {
                            PlayerGuess[y, x] = 'x';
                            Output += PlayerGuess[y, x];
                        }
                    }
                    else
                    {
                        Output += PlayerGuess[y, x];
                    }
                    
                }
                Output += "\n";
            }

            lblMineField.Text = Output;
            
           

           
        }

        /*
         Buttons 
         */

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnFlag_Click(object sender, EventArgs e)
        {
            ValidNum(txtbYpos.Text, txtbXpos.Text);
            Guess(UserY, UserX);
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {
            bool NewMap = false;
            ValidNum(txtbYpos.Text, txtbXpos.Text);
            NewMap = TheReveal(UserY, UserX);
            if (NewMap == false)
            {
                RefreshMap();
            }
            else
            {
                GameOver(NewMap);
            }
            //System.Windows.Forms.MessageBox.Show(Convert.ToString(Minesweep(UserY, UserX)));
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
            string Output = "";

            for (int y = 0; y < Height; y++) 
            {
                for (int x = 0; x < Width; x++) 
                {
                    if (MineField[y, x] != 'x')
                    {
                        MineField[y, x] = '.';
                    }
                    Output += MineField[y, x];
                }
                Output += "\n";
            }
            
            lblMineField.Text = Output;
        }
        private void btnNewG_Click(object sender, EventArgs e)
        {
            if (txtbXpos.Text == "111" && txtbYpos.Text == "111")
            {
                btnTest.Visible = true;
                btnTest.Enabled = true;
                txtbXpos.Text = "";
                txtbYpos.Text = "";
            }
            else
            {
                Hide();
                frmSetup Setup = new frmSetup();
                Setup.ResetAll();
                Setup.Show();
            }

        }
    }
}
