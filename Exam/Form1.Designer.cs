namespace Exam
{
    partial class frmSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbMapInfo = new System.Windows.Forms.GroupBox();
            this.txtbMineNum = new System.Windows.Forms.TextBox();
            this.txtbHMax = new System.Windows.Forms.TextBox();
            this.txtbWMax = new System.Windows.Forms.TextBox();
            this.txtbHMin = new System.Windows.Forms.TextBox();
            this.txtbWMin = new System.Windows.Forms.TextBox();
            this.lblHMax = new System.Windows.Forms.Label();
            this.lblHMin = new System.Windows.Forms.Label();
            this.lblWMax = new System.Windows.Forms.Label();
            this.lblWMin = new System.Windows.Forms.Label();
            this.lblMineNum = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbMapInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMapInfo
            // 
            this.grbMapInfo.Controls.Add(this.txtbMineNum);
            this.grbMapInfo.Controls.Add(this.txtbHMax);
            this.grbMapInfo.Controls.Add(this.txtbWMax);
            this.grbMapInfo.Controls.Add(this.txtbHMin);
            this.grbMapInfo.Controls.Add(this.txtbWMin);
            this.grbMapInfo.Controls.Add(this.lblHMax);
            this.grbMapInfo.Controls.Add(this.lblHMin);
            this.grbMapInfo.Controls.Add(this.lblWMax);
            this.grbMapInfo.Controls.Add(this.lblWMin);
            this.grbMapInfo.Controls.Add(this.lblMineNum);
            this.grbMapInfo.Controls.Add(this.lblHeight);
            this.grbMapInfo.Controls.Add(this.lblWidth);
            this.grbMapInfo.Location = new System.Drawing.Point(12, 27);
            this.grbMapInfo.Name = "grbMapInfo";
            this.grbMapInfo.Size = new System.Drawing.Size(366, 226);
            this.grbMapInfo.TabIndex = 8;
            this.grbMapInfo.TabStop = false;
            this.grbMapInfo.Text = "Map Size";
            // 
            // txtbMineNum
            // 
            this.txtbMineNum.Location = new System.Drawing.Point(128, 133);
            this.txtbMineNum.Name = "txtbMineNum";
            this.txtbMineNum.Size = new System.Drawing.Size(50, 20);
            this.txtbMineNum.TabIndex = 11;
            // 
            // txtbHMax
            // 
            this.txtbHMax.Location = new System.Drawing.Point(248, 85);
            this.txtbHMax.Name = "txtbHMax";
            this.txtbHMax.Size = new System.Drawing.Size(50, 20);
            this.txtbHMax.TabIndex = 10;
            // 
            // txtbWMax
            // 
            this.txtbWMax.Location = new System.Drawing.Point(248, 42);
            this.txtbWMax.Name = "txtbWMax";
            this.txtbWMax.Size = new System.Drawing.Size(50, 20);
            this.txtbWMax.TabIndex = 9;
            // 
            // txtbHMin
            // 
            this.txtbHMin.Location = new System.Drawing.Point(128, 85);
            this.txtbHMin.Name = "txtbHMin";
            this.txtbHMin.Size = new System.Drawing.Size(50, 20);
            this.txtbHMin.TabIndex = 8;
            // 
            // txtbWMin
            // 
            this.txtbWMin.Location = new System.Drawing.Point(128, 42);
            this.txtbWMin.Name = "txtbWMin";
            this.txtbWMin.Size = new System.Drawing.Size(50, 20);
            this.txtbWMin.TabIndex = 7;
            // 
            // lblHMax
            // 
            this.lblHMax.AutoSize = true;
            this.lblHMax.Location = new System.Drawing.Point(207, 88);
            this.lblHMax.Name = "lblHMax";
            this.lblHMax.Size = new System.Drawing.Size(30, 13);
            this.lblHMax.TabIndex = 6;
            this.lblHMax.Text = "Max:";
            // 
            // lblHMin
            // 
            this.lblHMin.AutoSize = true;
            this.lblHMin.Location = new System.Drawing.Point(87, 88);
            this.lblHMin.Name = "lblHMin";
            this.lblHMin.Size = new System.Drawing.Size(27, 13);
            this.lblHMin.TabIndex = 5;
            this.lblHMin.Text = "Min:";
            // 
            // lblWMax
            // 
            this.lblWMax.AutoSize = true;
            this.lblWMax.Location = new System.Drawing.Point(207, 45);
            this.lblWMax.Name = "lblWMax";
            this.lblWMax.Size = new System.Drawing.Size(30, 13);
            this.lblWMax.TabIndex = 4;
            this.lblWMax.Text = "Max:";
            // 
            // lblWMin
            // 
            this.lblWMin.AutoSize = true;
            this.lblWMin.Location = new System.Drawing.Point(87, 45);
            this.lblWMin.Name = "lblWMin";
            this.lblWMin.Size = new System.Drawing.Size(27, 13);
            this.lblWMin.TabIndex = 3;
            this.lblWMin.Text = "Min:";
            // 
            // lblMineNum
            // 
            this.lblMineNum.AutoSize = true;
            this.lblMineNum.Location = new System.Drawing.Point(20, 136);
            this.lblMineNum.Name = "lblMineNum";
            this.lblMineNum.Size = new System.Drawing.Size(92, 13);
            this.lblMineNum.TabIndex = 2;
            this.lblMineNum.Text = "Number Of Mines:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(20, 88);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(20, 45);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(366, 29);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 294);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(366, 29);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 329);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(366, 29);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 430);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grbMapInfo);
            this.Name = "frmSetup";
            this.Text = "Minesweeper";
            this.grbMapInfo.ResumeLayout(false);
            this.grbMapInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMapInfo;
        private System.Windows.Forms.TextBox txtbMineNum;
        private System.Windows.Forms.TextBox txtbHMax;
        private System.Windows.Forms.TextBox txtbWMax;
        private System.Windows.Forms.TextBox txtbHMin;
        private System.Windows.Forms.TextBox txtbWMin;
        private System.Windows.Forms.Label lblHMax;
        private System.Windows.Forms.Label lblHMin;
        private System.Windows.Forms.Label lblWMax;
        private System.Windows.Forms.Label lblWMin;
        private System.Windows.Forms.Label lblMineNum;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}

