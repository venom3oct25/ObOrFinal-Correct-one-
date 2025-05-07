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
            //lastname = (parts[1].Substring(0,1).ToUpper()) + 
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
        //List<statistic> baseballplayerstats = new List<statistic>();

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
                tempy.value = parts[i];//double.Parse(parts[i]);
                footballplayerstats.Add(tempy);
            }
            Console.WriteLine(parts[parts.Length - 2] + " " + parts[parts.Length - 1]);
            foreach (statistic cur in footballplayerstats)
            {
                Console.WriteLine(cur);
            }
        }
    }
}

