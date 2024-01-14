namespace Mainproject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            IntroLabel = new Label();
            StartGameButton = new Button();
            GuessBox = new TextBox();
            guessBoxInstruction = new Label();
            SubmitButton = new Button();
            ChampionListDataGrid = new DataGridView();
            ChampionListButton = new Button();
            HintButton = new Button();
            AllHintsbutton = new Button();
            ReturnToStart = new Button();
            ((System.ComponentModel.ISupportInitialize)ChampionListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // IntroLabel
            // 
            IntroLabel.AutoSize = true;
            IntroLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            IntroLabel.ForeColor = SystemColors.ControlText;
            IntroLabel.Location = new Point(266, 98);
            IntroLabel.Name = "IntroLabel";
            IntroLabel.Size = new Size(615, 64);
            IntroLabel.TabIndex = 1;
            IntroLabel.Text = "Welcome to League of Legends guessing game.\r\nYour goal is to guess the champion with the clues given.\r\n";
            // 
            // StartGameButton
            // 
            StartGameButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            StartGameButton.Location = new Point(503, 310);
            StartGameButton.Name = "StartGameButton";
            StartGameButton.Size = new Size(151, 80);
            StartGameButton.TabIndex = 2;
            StartGameButton.Text = "Start";
            StartGameButton.UseVisualStyleBackColor = true;
            StartGameButton.Click += startGameButton_Click;
            // 
            // GuessBox
            // 
            GuessBox.Location = new Point(528, 77);
            GuessBox.Name = "GuessBox";
            GuessBox.Size = new Size(100, 23);
            GuessBox.TabIndex = 3;
            // 
            // guessBoxInstruction
            // 
            guessBoxInstruction.AutoSize = true;
            guessBoxInstruction.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            guessBoxInstruction.Location = new Point(39, 66);
            guessBoxInstruction.Name = "guessBoxInstruction";
            guessBoxInstruction.Size = new Size(465, 32);
            guessBoxInstruction.TabIndex = 4;
            guessBoxInstruction.Text = "Type a champion and press submit button\r\n";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(522, 183);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(106, 23);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ChampionListDataGrid
            // 
            ChampionListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ChampionListDataGrid.GridColor = SystemColors.HotTrack;
            ChampionListDataGrid.Location = new Point(23, 275);
            ChampionListDataGrid.Name = "ChampionListDataGrid";
            ChampionListDataGrid.ReadOnly = true;
            ChampionListDataGrid.RowTemplate.Height = 25;
            ChampionListDataGrid.Size = new Size(376, 232);
            ChampionListDataGrid.TabIndex = 6;
            // 
            // ChampionListButton
            // 
            ChampionListButton.Location = new Point(91, 208);
            ChampionListButton.Name = "ChampionListButton";
            ChampionListButton.Size = new Size(140, 40);
            ChampionListButton.TabIndex = 7;
            ChampionListButton.Text = "List of Champions";
            ChampionListButton.UseVisualStyleBackColor = true;
            ChampionListButton.Click += ChampionListButton_Click;
            // 
            // HintButton
            // 
            HintButton.Location = new Point(522, 225);
            HintButton.Name = "HintButton";
            HintButton.Size = new Size(106, 23);
            HintButton.TabIndex = 8;
            HintButton.Text = "New Hint";
            HintButton.UseVisualStyleBackColor = true;
            HintButton.Click += HintButton_Click;
            // 
            // AllHintsbutton
            // 
            AllHintsbutton.Location = new Point(647, 225);
            AllHintsbutton.Name = "AllHintsbutton";
            AllHintsbutton.Size = new Size(106, 23);
            AllHintsbutton.TabIndex = 9;
            AllHintsbutton.Text = "Show Hints";
            AllHintsbutton.UseVisualStyleBackColor = true;
            AllHintsbutton.Click += AllHintsbutton_Click;
            // 
            // ReturnToStart
            // 
            ReturnToStart.Location = new Point(523, 270);
            ReturnToStart.Name = "ReturnToStart";
            ReturnToStart.Size = new Size(105, 23);
            ReturnToStart.TabIndex = 10;
            ReturnToStart.Text = "Go Back";
            ReturnToStart.UseVisualStyleBackColor = true;
            ReturnToStart.Click += ReturnToStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1131, 533);
            Controls.Add(ReturnToStart);
            Controls.Add(AllHintsbutton);
            Controls.Add(HintButton);
            Controls.Add(ChampionListButton);
            Controls.Add(ChampionListDataGrid);
            Controls.Add(SubmitButton);
            Controls.Add(guessBoxInstruction);
            Controls.Add(GuessBox);
            Controls.Add(StartGameButton);
            Controls.Add(IntroLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ChampionListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label IntroLabel;
        private Button StartGameButton;
        private TextBox GuessBox;
        private Label guessBoxInstruction;
        private Button SubmitButton;
        private DataGridView ChampionListDataGrid;
        private Button ChampionListButton;
        private Button HintButton;
        private Button AllHintsbutton;
        private Button ReturnToStart;
    }
}