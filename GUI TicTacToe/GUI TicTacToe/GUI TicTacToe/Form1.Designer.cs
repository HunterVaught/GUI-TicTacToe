
namespace GUI_TicTacToe
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.turnBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.recordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 98);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 98);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 98);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 98);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(204, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 98);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(336, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 98);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(67, 294);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 98);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(204, 294);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 98);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(336, 294);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 98);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(542, 294);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(165, 28);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "Play Again";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(542, 364);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(165, 28);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // turnBox
            // 
            this.turnBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.turnBox.Location = new System.Drawing.Point(542, 12);
            this.turnBox.Name = "turnBox";
            this.turnBox.Size = new System.Drawing.Size(165, 22);
            this.turnBox.TabIndex = 11;
            this.turnBox.Text = "X";
            // 
            // resultBox
            // 
            this.resultBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.resultBox.Location = new System.Drawing.Point(542, 52);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(165, 58);
            this.resultBox.TabIndex = 12;
            // 
            // recordLabel
            // 
            this.recordLabel.AutoSize = true;
            this.recordLabel.Location = new System.Drawing.Point(539, 133);
            this.recordLabel.Name = "recordLabel";
            this.recordLabel.Size = new System.Drawing.Size(65, 17);
            this.recordLabel.TabIndex = 13;
            this.recordLabel.Text = "Records:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.recordLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.turnBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TextBox turnBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label recordLabel;
    }
}

