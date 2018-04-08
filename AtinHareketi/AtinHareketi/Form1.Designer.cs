namespace AtinHareketi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.radioNine = new System.Windows.Forms.RadioButton();
            this.radioEight = new System.Windows.Forms.RadioButton();
            this.radioSeven = new System.Windows.Forms.RadioButton();
            this.radioSix = new System.Windows.Forms.RadioButton();
            this.radioFive = new System.Windows.Forms.RadioButton();
            this.GameBoard = new System.Windows.Forms.DataGridView();
            this.grpPossibleMoves = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMoveCounter = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).BeginInit();
            this.grpPossibleMoves.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.radioNine);
            this.groupBox1.Controls.Add(this.radioEight);
            this.groupBox1.Controls.Add(this.radioSeven);
            this.groupBox1.Controls.Add(this.radioSix);
            this.groupBox1.Controls.Add(this.radioFive);
            this.groupBox1.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 55);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start Game";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(438, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 36);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // radioNine
            // 
            this.radioNine.AutoSize = true;
            this.radioNine.Location = new System.Drawing.Point(371, 19);
            this.radioNine.Name = "radioNine";
            this.radioNine.Size = new System.Drawing.Size(52, 26);
            this.radioNine.TabIndex = 0;
            this.radioNine.TabStop = true;
            this.radioNine.Text = "9x9";
            this.radioNine.UseVisualStyleBackColor = true;
            // 
            // radioEight
            // 
            this.radioEight.AutoSize = true;
            this.radioEight.Location = new System.Drawing.Point(280, 19);
            this.radioEight.Name = "radioEight";
            this.radioEight.Size = new System.Drawing.Size(52, 26);
            this.radioEight.TabIndex = 0;
            this.radioEight.TabStop = true;
            this.radioEight.Text = "8x8";
            this.radioEight.UseVisualStyleBackColor = true;
            // 
            // radioSeven
            // 
            this.radioSeven.AutoSize = true;
            this.radioSeven.Location = new System.Drawing.Point(189, 19);
            this.radioSeven.Name = "radioSeven";
            this.radioSeven.Size = new System.Drawing.Size(52, 26);
            this.radioSeven.TabIndex = 0;
            this.radioSeven.TabStop = true;
            this.radioSeven.Text = "7x7";
            this.radioSeven.UseVisualStyleBackColor = true;
            // 
            // radioSix
            // 
            this.radioSix.AutoSize = true;
            this.radioSix.Location = new System.Drawing.Point(98, 20);
            this.radioSix.Name = "radioSix";
            this.radioSix.Size = new System.Drawing.Size(52, 26);
            this.radioSix.TabIndex = 0;
            this.radioSix.TabStop = true;
            this.radioSix.Text = "6x6";
            this.radioSix.UseVisualStyleBackColor = true;
            // 
            // radioFive
            // 
            this.radioFive.AutoSize = true;
            this.radioFive.Checked = true;
            this.radioFive.Location = new System.Drawing.Point(6, 19);
            this.radioFive.Name = "radioFive";
            this.radioFive.Size = new System.Drawing.Size(52, 26);
            this.radioFive.TabIndex = 0;
            this.radioFive.TabStop = true;
            this.radioFive.Text = "5x5";
            this.radioFive.UseVisualStyleBackColor = true;
            // 
            // GameBoard
            // 
            this.GameBoard.AllowUserToAddRows = false;
            this.GameBoard.AllowUserToDeleteRows = false;
            this.GameBoard.AllowUserToResizeColumns = false;
            this.GameBoard.AllowUserToResizeRows = false;
            this.GameBoard.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GameBoard.ColumnHeadersHeight = 10;
            this.GameBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GameBoard.ColumnHeadersVisible = false;
            this.GameBoard.Location = new System.Drawing.Point(12, 89);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.ReadOnly = true;
            this.GameBoard.RowHeadersVisible = false;
            this.GameBoard.RowHeadersWidth = 60;
            this.GameBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GameBoard.Size = new System.Drawing.Size(585, 480);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OyunTahtasi_CellClick);
            // 
            // grpPossibleMoves
            // 
            this.grpPossibleMoves.Controls.Add(this.label2);
            this.grpPossibleMoves.Controls.Add(this.lblMoveCounter);
            this.grpPossibleMoves.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.grpPossibleMoves.Location = new System.Drawing.Point(12, 591);
            this.grpPossibleMoves.Name = "grpPossibleMoves";
            this.grpPossibleMoves.Size = new System.Drawing.Size(251, 62);
            this.grpPossibleMoves.TabIndex = 1;
            this.grpPossibleMoves.TabStop = false;
            this.grpPossibleMoves.Text = "Possible Moves";
            this.grpPossibleMoves.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 1;
            // 
            // lblMoveCounter
            // 
            this.lblMoveCounter.AutoSize = true;
            this.lblMoveCounter.Location = new System.Drawing.Point(6, 29);
            this.lblMoveCounter.Name = "lblMoveCounter";
            this.lblMoveCounter.Size = new System.Drawing.Size(100, 22);
            this.lblMoveCounter.TabIndex = 0;
            this.lblMoveCounter.Text = "MoveCounter";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblGameResult);
            this.grpResult.Font = new System.Drawing.Font("Minion Pro", 12F);
            this.grpResult.Location = new System.Drawing.Point(281, 591);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(316, 62);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Game Result";
            this.grpResult.Visible = false;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.Location = new System.Drawing.Point(7, 28);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(88, 22);
            this.lblGameResult.TabIndex = 0;
            this.lblGameResult.Text = "GameResult";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 665);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpPossibleMoves);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Knight\'s Moves";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBoard)).EndInit();
            this.grpPossibleMoves.ResumeLayout(false);
            this.grpPossibleMoves.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton radioNine;
        private System.Windows.Forms.RadioButton radioEight;
        private System.Windows.Forms.RadioButton radioSeven;
        private System.Windows.Forms.RadioButton radioSix;
        private System.Windows.Forms.RadioButton radioFive;
        private System.Windows.Forms.DataGridView GameBoard;
        private System.Windows.Forms.GroupBox grpPossibleMoves;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMoveCounter;
        private System.Windows.Forms.Label lblGameResult;
    }
}

