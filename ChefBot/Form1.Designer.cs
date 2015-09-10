namespace ChefBot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Login = new System.Windows.Forms.GroupBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceSelection = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BrowserVisibility = new System.Windows.Forms.CheckBox();
            this.DifficultyButton = new System.Windows.Forms.Button();
            this.Difficulty = new System.Windows.Forms.ComboBox();
            this.Status = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentlySolving = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SolutionsSubmitted = new System.Windows.Forms.Label();
            this.ProblemsSolved = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.Login.SuspendLayout();
            this.ChoiceSelection.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.LoginButton);
            this.Login.Controls.Add(this.PasswordTextBox);
            this.Login.Controls.Add(this.UsernameTextBox);
            this.Login.Location = new System.Drawing.Point(12, 12);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(211, 114);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // LoginButton
            // 
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginButton.Location = new System.Drawing.Point(6, 77);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(6, 49);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(182, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.Text = "Password";
            this.PasswordTextBox.Enter += new System.EventHandler(this.PasswordTextBox_Enter);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(6, 21);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(182, 22);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.Text = "Username";
            this.UsernameTextBox.Enter += new System.EventHandler(this.UsernameTextBox_Enter);
            this.UsernameTextBox.Leave += new System.EventHandler(this.UsernameTextBox_Leave);
            // 
            // ChoiceSelection
            // 
            this.ChoiceSelection.Controls.Add(this.label6);
            this.ChoiceSelection.Controls.Add(this.BrowserVisibility);
            this.ChoiceSelection.Controls.Add(this.DifficultyButton);
            this.ChoiceSelection.Controls.Add(this.Difficulty);
            this.ChoiceSelection.Enabled = false;
            this.ChoiceSelection.Location = new System.Drawing.Point(229, 12);
            this.ChoiceSelection.Name = "ChoiceSelection";
            this.ChoiceSelection.Size = new System.Drawing.Size(251, 114);
            this.ChoiceSelection.TabIndex = 1;
            this.ChoiceSelection.TabStop = false;
            this.ChoiceSelection.Text = "Choice Selection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "(Higher difficulty levels may result in \r\nreduced number of successful submission" +
    "s)";
            // 
            // BrowserVisibility
            // 
            this.BrowserVisibility.AutoSize = true;
            this.BrowserVisibility.Checked = true;
            this.BrowserVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BrowserVisibility.Location = new System.Drawing.Point(6, 91);
            this.BrowserVisibility.Name = "BrowserVisibility";
            this.BrowserVisibility.Size = new System.Drawing.Size(100, 17);
            this.BrowserVisibility.TabIndex = 4;
            this.BrowserVisibility.Text = "Show Browser";
            this.BrowserVisibility.UseVisualStyleBackColor = true;
            this.BrowserVisibility.CheckedChanged += new System.EventHandler(this.BrowserVisibility_CheckedChanged);
            // 
            // DifficultyButton
            // 
            this.DifficultyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DifficultyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.DifficultyButton.Location = new System.Drawing.Point(143, 21);
            this.DifficultyButton.Name = "DifficultyButton";
            this.DifficultyButton.Size = new System.Drawing.Size(75, 23);
            this.DifficultyButton.TabIndex = 3;
            this.DifficultyButton.Text = "Submit";
            this.DifficultyButton.UseVisualStyleBackColor = true;
            this.DifficultyButton.Click += new System.EventHandler(this.DifficultyButton_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Difficulty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Difficulty.FormattingEnabled = true;
            this.Difficulty.Items.AddRange(new object[] {
            "All",
            "Beginner (School)",
            "Easy",
            "Medium",
            "Hard",
            "Challenge",
            "Peer (Extcontest)"});
            this.Difficulty.Location = new System.Drawing.Point(7, 21);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(121, 21);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.Text = "Select Difficulty";
            // 
            // Status
            // 
            this.Status.Controls.Add(this.label3);
            this.Status.Controls.Add(this.CurrentlySolving);
            this.Status.Controls.Add(this.label5);
            this.Status.Controls.Add(this.SolutionsSubmitted);
            this.Status.Controls.Add(this.ProblemsSolved);
            this.Status.Controls.Add(this.label2);
            this.Status.Controls.Add(this.label1);
            this.Status.Location = new System.Drawing.Point(486, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(286, 114);
            this.Status.TabIndex = 2;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label3.Location = new System.Drawing.Point(130, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "© 2015 Zyler. All Rights Reserved.";
            // 
            // CurrentlySolving
            // 
            this.CurrentlySolving.AutoSize = true;
            this.CurrentlySolving.Location = new System.Drawing.Point(6, 71);
            this.CurrentlySolving.Name = "CurrentlySolving";
            this.CurrentlySolving.Size = new System.Drawing.Size(26, 13);
            this.CurrentlySolving.TabIndex = 5;
            this.CurrentlySolving.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Currently Solving:";
            // 
            // SolutionsSubmitted
            // 
            this.SolutionsSubmitted.AutoSize = true;
            this.SolutionsSubmitted.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.SolutionsSubmitted.Location = new System.Drawing.Point(165, 31);
            this.SolutionsSubmitted.Name = "SolutionsSubmitted";
            this.SolutionsSubmitted.Size = new System.Drawing.Size(22, 17);
            this.SolutionsSubmitted.TabIndex = 3;
            this.SolutionsSubmitted.Text = "00";
            // 
            // ProblemsSolved
            // 
            this.ProblemsSolved.AutoSize = true;
            this.ProblemsSolved.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ProblemsSolved.Location = new System.Drawing.Point(6, 31);
            this.ProblemsSolved.Name = "ProblemsSolved";
            this.ProblemsSolved.Size = new System.Drawing.Size(22, 17);
            this.ProblemsSolved.TabIndex = 2;
            this.ProblemsSolved.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solutions Submitted:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problems Solved:";
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(12, 132);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.ScrollBarsEnabled = false;
            this.Browser.Size = new System.Drawing.Size(760, 417);
            this.Browser.TabIndex = 3;
            this.Browser.Url = new System.Uri("https://www.codechef.com/problems/easy", System.UriKind.Absolute);
            this.Browser.NewWindow += new System.ComponentModel.CancelEventHandler(this.Browser_NewWindow);
            // 
            // MainForm
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.ChoiceSelection);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "ChefBot v1.0.0  ~ Zyler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ChoiceSelection.ResumeLayout(false);
            this.ChoiceSelection.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.GroupBox ChoiceSelection;
        private System.Windows.Forms.ComboBox Difficulty;
        private System.Windows.Forms.Button DifficultyButton;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.CheckBox BrowserVisibility;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SolutionsSubmitted;
        private System.Windows.Forms.Label ProblemsSolved;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CurrentlySolving;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}

