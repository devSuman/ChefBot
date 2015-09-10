using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChefBot.Properties;


namespace ChefBot
{
    public partial class MainForm : Form
    {
        public Timer StatsFetcher = new Timer(); //This timer is used to fetch stats periodically
        public int AwaitTime; //This variable holds the ms time to wait after each successful submission

        public MainForm()
        {
            InitializeComponent();

            ((Control) Browser).Enabled = false;

            MessageBox.Show(
                @"This bot is developed by Zyler. Please use this bot at your own discretion. You are solely responsible for the usage of this bot and the developer cannot be held accountable for any mishaps.",
                @"Disclaimer", MessageBoxButtons.OK);

            StatsFetcher.Interval = 300000;
            StatsFetcher.Tick += StatsFetcherTick;
        }

        private async void StatsFetcherTick(object sender, EventArgs e)
        {
            // Fetch stats at given interval

            await TheBot.FetchStats(ProblemsSolved, SolutionsSubmitted, UsernameTextBox.Text);  
        }

        /// <summary>
        /// This event handles login/logout operations
        /// </summary>


        private async void LoginButton_Click(object sender, EventArgs e)
        {
            switch (LoginButton.Text)
            {
                case "Login":
                    if (await TheBot.LoginAsync(UsernameTextBox.Text, PasswordTextBox.Text, Browser))
                    {
                        // Continue with the program if no exception rises while logging in

                        LoginButton.Text = "Logout";
                        UsernameTextBox.Enabled = PasswordTextBox.Enabled = false;
                        ChoiceSelection.Enabled = true;
                        StatsFetcher.Start();
                    }
                    else
                    {
                        // Show error message if any exception rises when trying to log in

                        MessageBox.Show("An error occured. Please verify your credentials and try again.", "Error",
                            MessageBoxButtons.OK);
                        UsernameTextBox.Text = "Username";
                        PasswordTextBox.Text = "Password";
                    }
                    break;

                case "Logout":
                    try
                    {
                        StatsFetcher.Stop();
                        Browser.Navigate("https://codechef.com/logout");
                        ChoiceSelection.Enabled = false;
                        CurrentlySolving.Text = "NA";
                        LoginButton.Text = "Login";
                        UsernameTextBox.Text = "Username";
                        PasswordTextBox.Text = "Password";
                        await Task.Delay(3000);
                        UsernameTextBox.Enabled = PasswordTextBox.Enabled = true;
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                    break;    
            }
        }


        /// <summary>
        /// This event handles the main operation and only occurs when the user chooses a valid difficulty option
        /// </summary>

        private async void DifficultyButton_Click(object sender, EventArgs e)
        {
            List<string> linkList = SelectedChoice();
            linkList.RemoveAll(link => link.Length < 5); //Remove any improper links or blank lines

            if (!linkList.Any())
            {
                // Show error message if user selects and invalid choice

                MessageBox.Show("Invalid Selection", "Error");
            }
            else
            {
                // Disables difficulty combobox and button until current phase of submissions are complete.

                Difficulty.Enabled = DifficultyButton.Enabled = false;
                await TheBot.AutoSubmission(Browser, CurrentlySolving, linkList, AwaitTime);

                //Re-enable difficulty combobox and button after submission phase is finished

                Difficulty.Enabled = DifficultyButton.Enabled = true;
            }
        }

        #region SelectedChoice Method

        /// <summary>
        /// This method is used to assign await time and return problems list according to user's choice
        /// </summary>
        /// <returns>Problem links list</returns>

        private List<string> SelectedChoice()
        {
            switch (Difficulty.Text)
            {
                case "All":
                    AwaitTime = 25000;
                    return (Resources.All.Split('\n')).ToList();

                case "Beginner (School)":
                    AwaitTime = 10000;
                    return (Resources.School.Split('\n')).ToList();
                    
                case "Easy":
                    AwaitTime = 10000;
                    return (Resources.Easy.Split('\n')).ToList();

                case "Medium":                   
                    AwaitTime = 25000;
                    return (Resources.Medium.Split('\n')).ToList();

                case "Hard":
                    AwaitTime = 25000;
                    return (Resources.Hard.Split('\n')).ToList();

                case "Challenge":
                    AwaitTime = 30000;
                    return (Resources.Challenge.Split('\n')).ToList();

                case "Peer (Extcontest)":
                    AwaitTime = 30000;
                    return (Resources.Extcontest.Split('\n')).ToList();

                default:
                    return new List<string>();
            }
        }

#endregion

        #region Username and Password Textbox Placeholder Text Handling

        private void UsernameTextBox_Enter(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "Username")
                UsernameTextBox.Text = string.Empty;
        }

        private void UsernameTextBox_Leave(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == string.Empty)
                UsernameTextBox.Text = "Username";
        }

        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "Password")
                PasswordTextBox.Text = string.Empty;
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == string.Empty)
                PasswordTextBox.Text = "Password";
        }

        #endregion

        #region Miscellaneous Methods and Events

        /// <summary>
        /// This event prevents the WebBrowser from opening links on external browsers
        /// </summary>

        private void Browser_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Browser.Navigate(Browser.StatusText);
            e.Cancel = true;
        }

        /// <summary>
        /// This event handles "Show Browser" check box and modifies visibility of browser according to user choice
        /// </summary>

        private void BrowserVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (BrowserVisibility.Checked)
            {
                Browser.Visible = true;
                this.Height += Browser.Height;
            }
            else
            {
                Browser.Visible = false;
                this.Height -= Browser.Height;
            }
        }

        /// <summary>
        /// Handles form closing event. It asks whether the user is sure that he/she wants to exit.
        /// </summary>

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var choice = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);

            switch (choice)
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;

                case DialogResult.Yes:
                    if (LoginButton.Text == "Logout")
                    {
                        e.Cancel = true;
                        MessageBox.Show("Please logout before exiting the program.", "Error");
                    }
                    break;
            }
        }

#endregion

    }
}

