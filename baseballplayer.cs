using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObOrFinal
{
    internal class baseballplayer
    {
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public static string baseballlinkmaker(string nameinput)
        {
            string starter = "https://www.baseball-reference.com/players/";
            string end = "01.shtml";
            string final;
            string copy = nameinput;
            copy = copy.ToLower();
            string[] parts = copy.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastname = parts[1];
            string firtstlet = parts[1].Substring(0, 1);
            int longy = lastname.Length;
            if (longy < 5)
            {
                final = starter + firtstlet + "/" + parts[1].Substring(0, longy) + parts[0].Substring(0, 2) + end;
            }
            else
            {
                final = starter + firtstlet + "/" + parts[1].Substring(0, 5) + parts[0].Substring(0, 2) + end;
            }
            Console.WriteLine(final);
            return final;
        }
        public struct statistic
        {

            public string stored;
            public double value;
            public override string ToString()
            {
                return $"{stored}: {value}";
            }
        }
        //List<statistic> baseballplayerstats = new List<statistic>();

        public void baseballfillstat(string stats)
        {//WAR 182.6 AB 8399 H 2873 HR 714 BA .342 R 2174 RBI 2214 SB 123 OBP .474 SLG .690 OPS 1.164 OPS+ 206 Babe Ruth

            List<statistic> baseballplayerstats = new List<statistic>();
            string[] parts = stats.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _name = parts[parts.Length - 2] + parts[parts.Length - 1];
            for (int i = 0; i < parts.Length - 2; i++)
            {
                Point p = new Point { X = 10, Y = 20 };
                statistic tempy = new statistic();
                tempy.stored = parts[i];
                i++;
                tempy.value = double.Parse(parts[i]);
                baseballplayerstats.Add(tempy);
            }
            Console.WriteLine(parts[parts.Length-2] + " " + parts[parts.Length-1]);
            foreach (statistic cur in baseballplayerstats)
            {
                Console.WriteLine(cur);
            }
        }
            /*string[] parts = pulledtext.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _name = parts[0] + " " + parts[1]; // This combines first and last name

        }
        /*Wins abov replacement
         At Bats
        Hits
        Home Runs
        Hits at bat
        rns scored
        Runs batted in
        stolen bases*/
        }
    
    }
