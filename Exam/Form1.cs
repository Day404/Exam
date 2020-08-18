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
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        //Checks if the values are in accending order
        public static int TrueMax(int Min, int Max)
        {
            int TrueMax;
            if (Min > Max)
            {
                TrueMax = Min;
            }
            else
            {
                TrueMax = Max;
            }

            return TrueMax;
        }
        public static int TrueMin(int Min, int Max)
        {
            int TrueMin;
            if (Min > Max)
            {
                TrueMin = Max;
            }
            else
            {
                TrueMin = Min;
            }

            return TrueMin;
        }
        
        //Global Var
        public static int wMin, wMax, hMin, hMax, MineNo;

        //Checks if user entered correct information and corrects if needed
        public static bool ValidUserInput(string xMin, string xMax, string yMin, string yMax, string MineNum)
        {
            int NumYorN = -1;
            bool Valid = false;
            if (int.TryParse(xMin, out NumYorN) && int.TryParse(xMax, out NumYorN) && int.TryParse(yMin, out NumYorN) && int.TryParse(yMax, out NumYorN) && int.TryParse(MineNum, out NumYorN))
            {
                Valid = true;
                wMin = TrueMin(Convert.ToInt32(xMin), Convert.ToInt32(xMax));
                wMax = TrueMax(Convert.ToInt32(xMin), Convert.ToInt32(xMax));
                hMin = TrueMin(Convert.ToInt32(yMin), Convert.ToInt32(yMax));
                hMax = TrueMax(Convert.ToInt32(yMin), Convert.ToInt32(yMax));
                MineNo = Convert.ToInt32(MineNum);                
            }
            else
            {
                Valid = false;
                System.Windows.Forms.MessageBox.Show("Please Enter A Valid Number");
            }
            return Valid;

        }

        //Resets all editable text back to defualt
        public void ResetAll()
        {
            txtbHMax.Text = "";
            txtbHMin.Text = "";
            txtbMineNum.Text = "";
            txtbWMax.Text = "";
            txtbWMin.Text = "";

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetAll();
            System.Windows.Forms.MessageBox.Show("Map Size Is Reset To Defualt.");
        }

        //Closes program on click
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        //Sends & saves info to game form
        private void btnStart_Click(object sender, EventArgs e)
        {
            bool GoodInfo = ValidUserInput(txtbWMin.Text, txtbWMax.Text, txtbHMin.Text, txtbHMax.Text, txtbMineNum.Text);
            if (GoodInfo == true)
            {
                //System.Windows.Forms.MessageBox.Show("xMin: " + wMin + "\nxMax: " + wMax + "\nyMin: " + hMin + "\nyMax: " + hMax + "\nMines: " + MineNo);
                Hide();
                frmGame Game = new frmGame();
                Game.StartGame(wMin, wMax, hMin, hMax, MineNo);
                Game.Show();
            }
            
            

        }
    }
}
