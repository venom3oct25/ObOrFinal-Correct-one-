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
        #region BaseballMethods
        public string compare(string cur, string past)
        {
            //"Baseball players can have different types of and amount of stats based on position and years played. We were not able to get a function to handle every possible compared automatically. Sorry";
            string compared = "";
            double curVal, pastVal;
            string[] curparts = cur.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] pastparts = past.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 1; i<curparts.Length; i++)
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


        public void baseballfillstat(string stats)
        {

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
        #endregion
    }
}
