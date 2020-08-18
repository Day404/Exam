namespace Exam
{
    partial class frmGame
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
            this.lblMineField = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.lblXpos = new System.Windows.Forms.Label();
            this.lblYpos = new System.Windows.Forms.Label();
            this.txtbXpos = new System.Windows.Forms.TextBox();
            this.txtbYpos = new System.Windows.Forms.TextBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewG = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMineField
            // 
            this.lblMineField.AutoSize = true;
            this.lblMineField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMineField.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMineField.Location = new System.Drawing.Point(218, 190);
            this.lblMineField.Name = "lblMineField";
            this.lblMineField.Size = new System.Drawing.Size(100, 20);
            this.lblMineField.TabIndex = 0;
            this.lblMineField.Text = "MineField";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(512, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(71, 24);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score:";
            // 
            // lblActions
            // 
            this.lblActions.AutoSize = true;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.Location = new System.Drawing.Point(512, 77);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(185, 24);
            this.lblActions.TabIndex = 2;
            this.lblActions.Text = "Actions Remaining";
            // 
            // lblXpos
            // 
            this.lblXpos.AutoSize = true;
            this.lblXpos.Location = new System.Drawing.Point(513, 162);
            this.lblXpos.Name = "lblXpos";
            this.lblXpos.Size = new System.Drawing.Size(54, 13);
            this.lblXpos.TabIndex = 3;
            this.lblXpos.Text = "X Position";
            // 
            // lblYpos
            // 
            this.lblYpos.AutoSize = true;
            this.lblYpos.Location = new System.Drawing.Point(635, 162);
            this.lblYpos.Name = "lblYpos";
            this.lblYpos.Size = new System.Drawing.Size(54, 13);
            this.lblYpos.TabIndex = 4;
            this.lblYpos.Text = "Y Position";
            // 
            // txtbXpos
            // 
            this.txtbXpos.Location = new System.Drawing.Point(516, 190);
            this.txtbXpos.Name = "txtbXpos";
            this.txtbXpos.Size = new System.Drawing.Size(51, 20);
            this.txtbXpos.TabIndex = 5;
            // 
            // txtbYpos
            // 
            this.txtbYpos.Location = new System.Drawing.Point(638, 190);
            this.txtbYpos.Name = "txtbYpos";
            this.txtbYpos.Size = new System.Drawing.Size(51, 20);
            this.txtbYpos.TabIndex = 6;
            // 
            // btnReveal
            // 
            this.btnReveal.Location = new System.Drawing.Point(516, 245);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(181, 25);
            this.btnReveal.TabIndex = 7;
            this.btnReveal.Text = "Reveal Tile";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(516, 338);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 25);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Quit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewG
            // 
            this.btnNewG.Location = new System.Drawing.Point(516, 307);
            this.btnNewG.Name = "btnNewG";
            this.btnNewG.Size = new System.Drawing.Size(181, 25);
            this.btnNewG.TabIndex = 9;
            this.btnNewG.Text = "New Game";
            this.btnNewG.UseVisualStyleBackColor = true;
            this.btnNewG.Click += new System.EventHandler(this.btnNewG_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(516, 276);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(181, 25);
            this.btnFlag.TabIndex = 10;
            this.btnFlag.Text = "Flag Mine";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 415);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 11;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnFlag);
            this.Controls.Add(this.btnNewG);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.txtbYpos);
            this.Controls.Add(this.txtbXpos);
            this.Controls.Add(this.lblYpos);
            this.Controls.Add(this.lblXpos);
            this.Controls.Add(this.lblActions);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblMineField);
            this.Name = "frmGame";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMineField;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.Label lblXpos;
        private System.Windows.Forms.Label lblYpos;
        private System.Windows.Forms.TextBox txtbXpos;
        private System.Windows.Forms.TextBox txtbYpos;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNewG;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnTest;
    }
}