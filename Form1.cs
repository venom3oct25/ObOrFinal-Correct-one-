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

namespace ObOrFinal
{
    public partial class Form1 : Form
    {
        HTMLdata htmldataclass = new HTMLdata();
        public Form1()
        {
            InitializeComponent();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
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
            if(inputbox.Text != "")
            {
                nascarbutton.Enabled = false;
                footballbutton.Enabled = false;
                baseballbutton.Enabled = false;
                nascardriver nascardriver = new nascardriver();
                curdatabox.Text = "Loading";

                string html = await HTMLdata.nascarfind(inputbox.Text);
                
                
                string result = await Task.Run(() => HTMLdata.nascarExtractTextFromHtml(html,inputbox.Text));

                
                curdatabox.Text = result;
                nascarbutton.Enabled = true;
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
                footballplayer footballplayer = new footballplayer();
                curdatabox.Text = "Loading";
                string temp = inputbox.Text;
                if (temp.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length == 2)
                {
                    string html = await HTMLdata.footballfind(inputbox.Text);
                    htmldataclass.footballraw = html;
                    string result = await Task.Run(() => HTMLdata.footballExtractTextFromHtml(html, inputbox.Text));

                    curdatabox.Text = result;
                }
                else
                {
                    curdatabox.Text = "First and Last name";
                }
                
                nascarbutton.Enabled = true;
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
                baseballplayer baseballplayer = new baseballplayer();
                curdatabox.Text = "Loading";
                string temp = inputbox.Text;
                if (temp == null || temp.Trim().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Length != 2)
                {
                    curdatabox.Text = "First and Last Name please";
                }
                else {
                    string html = await HTMLdata.baseballfind(inputbox.Text);
                    //Console.WriteLine(html);
                    htmldataclass.baseballraw = html;
                   // Console.WriteLine(htmldataclass.baseballraw);
                    string result = await Task.Run(() => HTMLdata.baseballExtractTextFromHtml(html, inputbox.Text));


                    curdatabox.Text = result;
                }
            }
            else
            {
                curdatabox.Text = "Empty error";
            }
            nascarbutton.Enabled = true;
            footballbutton.Enabled = true;
            baseballbutton.Enabled = true;
        }

        private void rawdatabutton_Click(object sender, EventArgs e)
        {
            curdatabox.Text = "raw beef";
            Console.WriteLine(htmldataclass.baseballraw);
            Console.WriteLine(htmldataclass.footballraw);
        }
    }
}
