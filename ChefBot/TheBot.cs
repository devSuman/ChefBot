using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefBot
{
    /// <summary>
    /// This is the main bot worker class which handles most bot operations
    /// </summary>
    
    internal static class TheBot
    {

        #region Auto Submission Method

        /// <summary>
        /// This is the crucial auto submission method used to primarily handle the bot's auto submission work
        /// </summary>
        /// <param name="browser">WebBrowser to operate on</param>
        /// <param name="currentlySolving">Label to show the currently solving problem's name</param>
        /// <param name="linkList">List of problem links to solve</param>
        /// <param name="awaitTime">Awaiting time after each successful submission</param>
        /// <returns>Bool value addressing the success of the method</returns>

        public async static Task<bool> AutoSubmission(WebBrowser browser, Label currentlySolving, List<string> linkList, int awaitTime)
        {
            while(linkList.Any())
            {
                try
                {
                    Random rng = new Random();

                    var falseSubmission = rng.Next(3); // Total false submissions for each problem

                    // Take out a link and remove it from the list afterwards

                    var indexToRemove = rng.Next(linkList.Count);
                    var link = linkList[indexToRemove];
                    linkList.RemoveAt(indexToRemove);
                    string solutionListPageHtml;

                    using (var client = new WebClient())
                    {
                        // Extract solution list page's html and update currently solving label's text

                        solutionListPageHtml =
                            await
                                client.DownloadStringTaskAsync(
                                    StringManupulation.LinkToSolutions(link.Replace("\r", string.Empty)));

                        currentlySolving.Text =
                            Regex.Match(client.DownloadString(link), @"(?<=<title>)(.*)(?= \| CodeChef</title>)")
                                .ToString();
                    }

                    for (int count = 1; count <= falseSubmission; count++)
                    {
                        // False submissions

                        browser.Navigate(StringManupulation.LinkToSubmission(link));
                        await Submit(browser, StringManupulation.FakeSourceCodeGenerator());
                    }

                    // Navigate to submission page and finally submit the correct solution

                    browser.Navigate(StringManupulation.LinkToSubmission(link));
                    await Submit(browser, StringManupulation.ExtractedSolution(solutionListPageHtml));
                }
                catch (Exception)
                {
                    // ignored
                }
                finally
                {
                    // Wait for awaitTime before jumping for the next submission

                    await Task.Delay(awaitTime);
                }
            }
            return true;
        }

#endregion

        #region Submit Method

        /// <summary>
        /// This is the primary submit method used to submit solution for a problem
        /// </summary>
        /// <param name="browser">WebBrowser to operate on</param>
        /// <param name="solution">Solution to submit</param>
        /// <returns>Bool value addressing the success of the method</returns>

        private static async Task<bool> Submit(WebBrowser browser, string solution)
        {
            try
            {
                //Initially wait for 2 seconds and let the browser complete loading and start operation afterwards

                await Task.Delay(2000);

                browser.Document.GetElementById("edit_area_toggle_checkbox_edit-body").InvokeMember("Click");
                browser.Document.GetElementById("edit-body").InnerText = solution;
                browser.Document.GetElementById("edit-submit").InvokeMember("Click");
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                //Wait for 10 seconds before next submission

                await Task.Delay(10000);
            }
            return true;
        }

#endregion

        #region Fetch Stats Method

        /// <summary>
        /// This method is used to fetch the user submission stats
        /// </summary>
        /// <param name="problemsSolved">Label to print the total fetched problems solved stats</param>
        /// <param name="solutionsSubmitted">Label to print the total fetched solutions submitted stats</param>
        /// <param name="username">Username of the user to fetch stats for</param>
        /// <returns>Bool value addressing the success of the method</returns>

        public async static Task<bool> FetchStats(Label problemsSolved, Label solutionsSubmitted, string username)
        {
            try
            {
                using (var client = new WebClient())
                {
                    //Download the html document data of the profile page

                    var html =
                        await
                            client.DownloadStringTaskAsync
                            (new Uri(string.Format(@"https://codechef.com/users/" + username), 
                            UriKind.Absolute));

                    var statsPattern = new Regex(@"(?<=<td>)\d+(?=</td>)");

                    //Parse the data and print them on the appropriate labels

                    problemsSolved.Text = statsPattern.Matches(html)[0].ToString();
                    solutionsSubmitted.Text = statsPattern.Matches(html)[2].ToString();
                }
            }
            catch (Exception)
            {       
                return false;
            }    
            return true;
        }

#endregion

        #region Login Async Method

        /// <summary>
        /// This method is used to asynchronously login to CodeChef
        /// </summary>
        /// <param name="username">Username for the login credential</param>
        /// <param name="password">Password for the login credential</param>
        /// <param name="browser">WebBrowser to operate on</param>
        /// <returns>Bool value addressing the success of the method</returns>

        public static async Task<bool> LoginAsync(string username, string password, WebBrowser browser)
        {
            try
            {
                //Input username and password in the proper input boxes and hit submit

                browser.Document.GetElementById("edit-name").InnerText = username;
                browser.Document.GetElementById("edit-pass").InnerText = password;
                browser.Document.GetElementById("edit-submit").InvokeMember("Click");
            }

            catch (Exception)
            {
                await Task.Delay(1000);
                return false;
            }
            await Task.Delay(1000);
            return true;
        }

#endregion

    }
}
