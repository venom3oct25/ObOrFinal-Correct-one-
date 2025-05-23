using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Diagnostics.Eventing.Reader;

namespace ObOrFinal
{
    internal class HTMLdata
    {
        #region rawhtml
        private string _baseballraw;
        public string baseballraw
        {
            get
            {
                return _baseballraw;
            }
            set
            {
                _baseballraw = value;
            }
        }
        private string _footballraw;
        public string footballraw
        {
            get
            {
                return _footballraw;
            }
            set
            {
                _footballraw = value;
            }
        }
        private string _nascarraw;
        public string nascarraw
        {
            get
            {
                return _nascarraw;
            }
            set
            {
                _nascarraw = value;
            }
        }
        #endregion
        #region call methods

        public static async Task<string> nascarfind(string hatedriver)
        {
            //string url = "z";
            string url = "https://www.driveraverages.com/nascar/nascar-stats.php";
            string pulledtext = await CallURL(url);
            Console.WriteLine("nascar url called");
            return pulledtext;
        }
        public static async Task<string> baseballfind(string hatebaseball)
        {
            string url = baseballplayer.baseballlinkmaker(hatebaseball);
            string pulledtext = await CallURL(url);
            Console.WriteLine("baseball url called");
            return pulledtext;
        }
        public static async Task<string> footballfind(string hatefootball)
        {
            string url = footballplayer.footballlinkmaker(hatefootball);
            string pulledtext = await CallURL(url);
            Console.WriteLine("football url called");
            return pulledtext;
        }


        public static async Task<string> CallURL(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; // Use Tls12
                    client.DefaultRequestHeaders.Accept.Clear();
                    return await client.GetStringAsync(url);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CallURL: " + ex.Message);
                return " ";
            }
        }
        #endregion
        #region ExtractMethods
        public static string nascarExtractTextFromHtml(string html, string hatedriver)
        {
                if (html == null)
                {
                    return "empty";
                }
                string plainText = Regex.Replace(html, "\r?\n|<[^>]+?>|/[^/]+?/|{[^}]+?}", " ");
                plainText = System.Net.WebUtility.HtmlDecode(plainText).Trim();
                int index = plainText.IndexOf(hatedriver, StringComparison.OrdinalIgnoreCase);
                if (index >= 0)
                {
                    plainText = plainText.Substring(index).Trim();
                }
                int percentIndex = plainText.IndexOf('%');
                if (percentIndex >= 0)
                {
                    plainText = plainText.Substring(0, percentIndex).Trim();
                }
            if (plainText.Substring(0, 6) == "NASCAR")
            {
                return "error, nascar not found";
            }
            else
            {
                string[] parts = plainText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                plainText = "";
                for (int i = 0; i < 10; i++)
                {
                    plainText = plainText + " " + parts[i];
                }
                return plainText;
            }
        }
        public static string baseballExtractTextFromHtml(string html, string hatebaseball)
        {
            if (html == null)
            {
                return "empty";
            }
            string plainText = Regex.Replace(html, "\r?\n|<[^>]+?>|/[^/]+?/|{[^}]+?}", " ");
            plainText = System.Net.WebUtility.HtmlDecode(plainText).Trim();
            int index = plainText.IndexOf("Career");
            if (index >= 0)
            {
                plainText = plainText.Substring(index).Trim();
            }
            int percentIndex = plainText.IndexOf("Overview");
            if (percentIndex >= 0)
            {
                plainText = plainText.Substring(0, percentIndex).Trim();
            }
            plainText = plainText.Replace("Total Bases AB  For recent years, leaders need 3.1 PA per team game played\">", " ");
            plainText = plainText.Replace("SUMMARY", "");
            plainText = plainText.Replace("Career", "");
            plainText = plainText.Replace("2024", "");
            string[] parts = plainText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                plainText = "";
            int takeCount = Math.Min(19, parts.Length);
            for (int i = 0; i < parts.Length; i++)
            {
                plainText += " " + parts[i];
            }
            if(plainText == "")
            {
                return "Error, baseball not found";
            }
            else
            {
                plainText = plainText.Replace("\t\t \t\t \t \t \t \t\t ", "");
                return plainText;
            }
        }
        

        public static string footballExtractTextFromHtml(string html, string hatefootball)
        {//open each name and index until you find the match
            if (html == null)
            {
                return "empty";
            }
            
            //cleans name input
            string plainText = Regex.Replace(html, "\r?\n|<[^>]+?>|/[^/]+?/|{[^}]+?}", " ");
            plainText = System.Net.WebUtility.HtmlDecode(plainText).Trim();

            int index = 0;
            if (plainText.Contains("SUMMARY     2024     Career"))
            {
                index = plainText.IndexOf("SUMMARY     2024     Career");
            }
            else if (plainText.Contains("SUMMARY      Career"))
            {
                index = plainText.IndexOf("SUMMARY      Career");
            }
            if (index >= 0)
            {
                plainText = plainText.Substring(index).Trim();
            }
            int percentIndex = plainText.IndexOf("Overview");
            if (percentIndex >= 0)
            {
                plainText = plainText.Substring(0, percentIndex).Trim();
            }
            if (Regex.IsMatch(plainText, @"minimum.*?leader", RegexOptions.IgnoreCase))
            {
                plainText = Regex.Replace(plainText, @"minimum.*?leader", "", RegexOptions.IgnoreCase).Trim();
            }
            plainText = plainText.Replace("See our About section for more details.\">", " ");
            plainText = plainText.Replace("Minimum 14 attempts per scheduled game to qualify as leader.Minimum 1500 pass attempts to qualify as career leader.\">", " ");
            plainText = plainText.Replace("For teams, sack yardage is deducted from this total\">", " ");
            plainText = plainText.Replace("       Fantasy points:   \t\t\t\t\t\t\t\t1 point per 25 yards passing  \t\t\t\t\t\t\t\t4 points per passing touchdown  \t\t\t\t\t\t\t\t-2 points per interception thrown  \t\t\t\t\t\t\t\t1 point per 10 yards rushing > \t\t\t\t\t\t\t\t6 points per TD  \t\t\t\t\t\t\t\t2 points per two-point conversion  \t\t\t\t\t\t\t\t-2 points per fumble lost (est. prior to 1994)\"> ", " ");
            plainText = plainText.Replace(" strong>", "/A");
            plainText = plainText.Replace("SUMMARY", "");
            plainText = plainText.Replace("Career", "");
            plainText = plainText.Replace("2024", "");
            plainText = plainText.Replace(". .\">", "");
             percentIndex = plainText.IndexOf("4/A");
            if (percentIndex >= 0)
            {
                plainText = plainText.Substring(0, percentIndex).Trim();
            }
            plainText = plainText.Replace("\t", "");
            if (!plainText.Contains(hatefootball))
            {
                plainText += (" " + hatefootball);
            }
            string[] parts = plainText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            plainText = "";
            for (int i = 0; i < parts.Length; i++)
            {
                plainText += " " + parts[i];
            }
            if (plainText == "")
            {
                return "Error, football not found";
            }
            else
            {
                return plainText;
            }
          }
        #endregion


    }
}
