namespace GuessingGame
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
            this.startLabel = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.gamesPlayedLabel = new System.Windows.Forms.Label();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.nameMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.startGameButton = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(376, 221);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(716, 55);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "GUESS THE NUMBER ( 1-10):";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTextBox.Location = new System.Drawing.Point(1107, 221);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(495, 62);
            this.guessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.BackColor = System.Drawing.SystemColors.Info;
            this.guessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessButton.Location = new System.Drawing.Point(1635, 205);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(284, 78);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "GUESS";
            this.guessButton.UseVisualStyleBackColor = false;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attemptsLabel.Location = new System.Drawing.Point(385, 555);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(279, 55);
            this.attemptsLabel.TabIndex = 3;
            this.attemptsLabel.Text = "ATTEMPTS";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(409, 308);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(214, 55);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "RESULT";
            // 
            // gamesPlayedLabel
            // 
            this.gamesPlayedLabel.AutoSize = true;
            this.gamesPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesPlayedLabel.Location = new System.Drawing.Point(390, 654);
            this.gamesPlayedLabel.Name = "gamesPlayedLabel";
            this.gamesPlayedLabel.Size = new System.Drawing.Size(400, 55);
            this.gamesPlayedLabel.TabIndex = 6;
            this.gamesPlayedLabel.Text = "GAMES PLAYED";
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(1107, 400);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(873, 537);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 7;
            this.resultPictureBox.TabStop = false;
            // 
            // nameMaskedTextBox
            // 
            this.nameMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameMaskedTextBox.Location = new System.Drawing.Point(936, 47);
            this.nameMaskedTextBox.Mask = "??????????????";
            this.nameMaskedTextBox.Name = "nameMaskedTextBox";
            this.nameMaskedTextBox.Size = new System.Drawing.Size(482, 62);
            this.nameMaskedTextBox.TabIndex = 8;
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(1447, 21);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(303, 121);
            this.startGameButton.TabIndex = 9;
            this.startGameButton.Text = "PRESS HERE TO START THE GAME";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(376, 54);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(554, 55);
            this.nameLbl.TabIndex = 10;
            this.nameLbl.Text = "WHAT IS YOUR NAME?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2618, 1213);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.nameMaskedTextBox);
            this.Controls.Add(this.resultPictureBox);
            this.Controls.Add(this.gamesPlayedLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.startLabel);
            this.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label attemptsLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label gamesPlayedLabel;
        private System.Windows.Forms.PictureBox resultPictureBox;
        private System.Windows.Forms.MaskedTextBox nameMaskedTextBox;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Label nameLbl;
    }
}

