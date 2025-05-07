using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Collections;
using System.Drawing.Drawing2D;

namespace ObOrFinal
{
    public partial class Form1 : Form
    {
        HTMLdata htmldataclass = new HTMLdata();
        Dictionary<string, string> curdata = new Dictionary<string, string>();
        Dictionary<string, string> pastdata = new Dictionary<string, string>();
        string bulkpastdata;
        public void readpast()
        {

            string[] rawentry = File.ReadAllLines("C:\\Users\\dj062\\OneDrive\\Desktop\\ObOrFinal\\pastdatalog.txt");

            foreach (string entry in rawentry)
            {
                if (entry.StartsWith("[") && entry.EndsWith("]"))
                {
                    string nobrac = entry.Trim('[', ']');
                    int commaIndex = nobrac.IndexOf(',');

                    if (commaIndex > -1)
                    {
                        string key = nobrac.Substring(0, commaIndex).Trim();
                        string value = nobrac.Substring(commaIndex + 1).Trim();
                        pastdata[key] = value;
                    }

                }
            }

            bulkpastdata = File.ReadAllText("C:\\Users\\dj062\\OneDrive\\Desktop\\ObOrFinal\\pastdatalog.txt");
            foreach (var entry in pastdata)
            {
                Console.WriteLine($"Name: {entry.Key}\nStats: {entry.Value}\n");
            }

        }
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            readpast();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void nascarbutton_Click(object sender, EventArgs e)
        {
            if (inputbox.Text != "")
            {
                nascarbutton.Enabled = false;
                footballbutton.Enabled = false;
                baseballbutton.Enabled = false;
                savebut.Enabled = false;
                pastfilebutton.Enabled = false;
                rawdatabutton.Enabled = false;
                nascardriver nascardriver = new nascardriver();
                string nameheld = inputbox.Text;
                nameheld = nameheld.ToLower();
                string[] caps = nameheld.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                nameheld = caps[0].Substring(0, 1).ToUpper() + caps[0].Substring(1, caps[0].Length - 1) + " " + caps[1].Substring(0, 1).ToUpper() + caps[1].Substring(1, caps[1].Length - 1);
                curdatabox.Text = "Loading";

                string html = await HTMLdata.nascarfind(nameheld);


                string result = await Task.Run(() => HTMLdata.nascarExtractTextFromHtml(html, nameheld));


                curdatabox.Text = result;
                curdata.Add(nameheld, result);
                nascarbutton.Enabled = true;
                savebut.Enabled = true;
                pastfilebutton.Enabled = true;
                rawdatabutton.Enabled = true;
                footballbutton.Enabled = true;
                baseballbutton.Enabled = true;
            }
            else
            {
                curdatabox.Text = "Empty error";
            }


        }

        private async void footballbutton_ClickAsync(object sender, EventArgs e)
        {
            if (inputbox.Text != "")
            {

                nascarbutton.Enabled = false;
                footballbutton.Enabled = false;
                baseballbutton.Enabled = false;
                savebut.Enabled = false;
                pastfilebutton.Enabled = false;
                rawdatabutton.Enabled = false;
                footballplayer footballplayer = new footballplayer();
                string nameheld = inputbox.Text;
                nameheld = nameheld.ToLower();
                string[] caps = nameheld.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                nameheld = caps[0].Substring(0, 1).ToUpper() + caps[0].Substring(1, caps[0].Length - 1) + " " + caps[1].Substring(0, 1).ToUpper() + caps[1].Substring(1, caps[1].Length - 1);
                curdatabox.Text = "Loading";
                string temp = nameheld;
                if (temp.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length == 2)
                {
                    string html = await HTMLdata.footballfind(nameheld);
                    htmldataclass.footballraw = html;
                    string result = await Task.Run(() => HTMLdata.footballExtractTextFromHtml(html, nameheld));

                    curdatabox.Text = result;
                    curdata.Add(nameheld, result);
                    footballplayer.footballfillstat(result);
                }
                else
                {
                    curdatabox.Text = "First and Last name";
                }

                nascarbutton.Enabled = true;
                savebut.Enabled = true;
                pastfilebutton.Enabled = true;
                rawdatabutton.Enabled = true;
                footballbutton.Enabled = true;
                baseballbutton.Enabled = true;
            }
            else
            {
                curdatabox.Text = "Empty error";
            }
        }

        private async void baseballbutton_Click(object sender, EventArgs e)
        {
            if (inputbox.Text != "")
            {


                nascarbutton.Enabled = false;
                footballbutton.Enabled = false;
                baseballbutton.Enabled = false;
                savebut.Enabled = false;
                pastfilebutton.Enabled = false;
                rawdatabutton.Enabled = false;
                baseballplayer baseballplayer = new baseballplayer();
                string nameheld = inputbox.Text;
                nameheld = nameheld.ToLower();
                string[] caps = nameheld.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                nameheld = caps[0].Substring(0, 1).ToUpper() + caps[0].Substring(1, caps[0].Length - 1) + " " + caps[1].Substring(0, 1).ToUpper() + caps[1].Substring(1, caps[1].Length - 1);
                curdatabox.Text = "Loading";
                string temp = nameheld;
                if (temp == null || temp.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length != 2)
                {
                    curdatabox.Text = "First and Last Name please";
                }
                else
                {
                    string html = await HTMLdata.baseballfind(nameheld);
                    //Console.WriteLine(html);
                    htmldataclass.baseballraw = html;
                    // Console.WriteLine(htmldataclass.baseballraw);
                    string result = await Task.Run(() => HTMLdata.baseballExtractTextFromHtml(html, nameheld));


                    curdatabox.Text = result;
                    curdata.Add(nameheld, result);
                    baseballplayer.baseballfillstat(result);
                }
            }
            else
            {
                curdatabox.Text = "Empty error";
            }
            nascarbutton.Enabled = true;
            savebut.Enabled = true;
            pastfilebutton.Enabled = true;
            rawdatabutton.Enabled = true;
            footballbutton.Enabled = true;
            baseballbutton.Enabled = true;
        }

        private void rawdatabutton_Click(object sender, EventArgs e)
        {
            thebigone.Text = "raw beef";
            thebigone.Text = ;
            Console.WriteLine(htmldataclass.baseballraw);
            Console.WriteLine(htmldataclass.footballraw);
        }

        private void savebut_Click(object sender, EventArgs e)
        {
            string file = @"C:\Users\dj062\OneDrive\Desktop\ObOrFinal\pastdatalog.txt";
            foreach (var entry in curdata)
            {
                if (pastdata.ContainsKey(entry.Key))
                {
                    pastdata[entry.Key] = entry.Value;
                }
            }
            File.WriteAllText(file, "");
            foreach (var entry in pastdata)
            {
                if (!curdata.ContainsKey(entry.Key))
                {
                    curdata[entry.Key] = entry.Value;
                }
            }
            foreach (var entry in curdata)
            {
                File.AppendAllText(file, entry.ToString());
                File.AppendAllText(file, "\n");
            }
        }

        private void curdatabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pastfilebutton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
