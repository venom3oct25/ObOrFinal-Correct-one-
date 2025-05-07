using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObOrFinal
{
    internal class footballplayer

    {
        #region FootballMethods
        public string compare(string cur, string past)
        {
            //"Football players can have different types of and amount of stats based on position and years played. We were not able to get a function to handle every possible compared automatically. Sorry";
            string compared = "";
            double curVal, pastVal;
            string[] curparts = cur.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] pastparts = past.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i < curparts.Length; i++)
            {
                if (double.TryParse(curparts[i], out curVal) && double.TryParse(pastparts[i], out pastVal))
                {
                    if (double.Parse(curparts[i]) <= double.Parse(pastparts[i]))
                    {
                        compared = compared + "Bad - ";
                    }
                    else
                    {
                        compared = compared + "Good - ";
                    }
                }

                i++;
            }
            return compared;
        }
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
        //https://www.pro-football-reference.com/players/B/BailJo00.htm
        public static string footballlinkmaker(string nameinput)
        {
            if (nameinput == "David Baas")
            {
                return "https://www.pro-football-reference.com/players/B/BaasDa20.htm";
            }
            else { }
            string starter = "https://www.pro-football-reference.com/players/";
            string end = "00.htm";
            string final;
            string copy = nameinput;
            copy = copy.ToLower();
            string[] parts = copy.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string lastname = parts[1];
            string firtstlet = parts[1].Substring(0, 1).ToUpper();
            string firstletfirst = parts[0].Substring(0, 1).ToUpper();
            int longy = lastname.Length;
            if (longy < 4)
            {
                final = starter + firtstlet + "/" + firtstlet + parts[1].Substring(1, longy) + firstletfirst + parts[0].Substring(1, 1) + end;
            }
            else
            {
                final = starter + firtstlet + "/" + firtstlet + parts[1].Substring(1, 3) + firstletfirst + parts[0].Substring(1, 1) + end;
            }
            Console.WriteLine(final);
            return final;
        }
        public struct statistic
        {
            public string stored;
            public string value;
            public override string ToString()
            {
                return $"{stored}: {value}";
            }
        }


        public void footballfillstat(string stats)
        {
            List<statistic> footballplayerstats = new List<statistic>();
            string[] parts = stats.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _name = parts[parts.Length - 2] + parts[parts.Length - 1];
            for (int i = 0; i < parts.Length - 2; i++)
            {
                Point p = new Point { X = 10, Y = 20 };
                statistic tempy = new statistic();
                tempy.stored = parts[i];
                i++;
                tempy.value = parts[i];
                footballplayerstats.Add(tempy);
            }
            Console.WriteLine(parts[parts.Length - 2] + " " + parts[parts.Length - 1]);
            foreach (statistic cur in footballplayerstats)
            {
                Console.WriteLine(cur);
            }
        }
        #endregion 
    }
}

