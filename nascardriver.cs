using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObOrFinal
{
    internal class nascardriver
    {

        /*NascarDriver:
Stores the name of driver, their stats, and the code to compare changes for nascar drivers*/
        #region NASCARmethods
        public string compare(string cur, string past) {
            //Points: 408 AvgFin: 10.6 Races: 11 Wins: 2 Top5: 7 Top10: 8 LapLead: 596 AvgRate: 98.3 
            string[] curparts = cur.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] pastparts = past.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string compared = "";
            _points = int.Parse(curparts[1]);
            _races = int.Parse(curparts[5]);
            _avgfinish = double.Parse(curparts[3]);
            _wins = int.Parse(curparts[7]);
            _lapslead = int.Parse(curparts[13]);
            _top5 = int.Parse(curparts[9]);
            _top10 = int.Parse(curparts[11]);
            _avgrate = double.Parse(curparts[15]);
            if (_points <= int.Parse(pastparts[1]) && _races > int.Parse(pastparts[5]))
            {
                compared += "Points Down - ";

            }
            else
            {
                compared += "Points Good - ";
            }
            if (_avgfinish < double.Parse(pastparts[3]) && _races > int.Parse(pastparts[5]))
            {
                compared += "AvgFinish Down - ";

            }
            else
            {
                compared += "AvgFinish Good - ";
            }
            if (_avgrate < double.Parse(pastparts[15]) && _races > int.Parse(pastparts[5]))
            {
                compared += "AvgRate Down - ";

            }
            else
            {
                compared += "AvgRate Good - ";
            }
            if (_wins <= int.Parse(pastparts[7]) && _races > int.Parse(pastparts[5]))
            {
                compared += "Wins Down - ";

            }
            else
            {
                compared += "Wins Good - ";
            }
            if (_lapslead <= int.Parse(pastparts[13]+25) && _races > int.Parse(pastparts[5]))
            {
                compared += "Lap Lead Down - ";

            }
            else
            {
                compared += "Lap Lead Good - ";
            }
            if (_top5 <= int.Parse(pastparts[9]) && _races > int.Parse(pastparts[5]))
            {
                compared += "Top 5 Down - ";

            }
            else
            {
                compared += "Top 5 Good - ";
            }
            if (_top10 <= int.Parse(pastparts[11]) && _races > int.Parse(pastparts[5]))
            {
                compared += "Top 10 Down - ";

            }
            else
            {
                compared += "Top 10 Good - ";
            }
            return compared;


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
        public string nascarfillstats(string stats)
        {
            List<statistic> nascarplayerstats = new List<statistic>();
            string[] parts = stats.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _name = parts[0] + parts[1];
            for (int i = 2; i < parts.Length; i++)
            {
                string[] titles = { "Points: ", "AvgFin: ", "Races: ", "Wins: ", "Top5: ", "Top10: ", "LapLead: ", "AvgRate: "};
                Point p = new Point { X = 10, Y = 20 };
                statistic tempy = new statistic();
                tempy.stored = titles[i-2];

                tempy.value = parts[i];//double.Parse(parts[i]);
                nascarplayerstats.Add(tempy);
            }
            Console.WriteLine(parts[parts.Length - 2] + " " + parts[parts.Length - 1]);
            string combine = "";
            foreach (statistic cur in nascarplayerstats)
            {
                combine = combine + cur.stored + cur.value + " ";
                Console.WriteLine(cur);
            }
            return combine;
        }
        #endregion
        #region Stats

        private string _raw;
        public string raw
        {
            get
            {
                return _raw;
            }
            set
            {
                _raw = value;
            }
        }
        private int _races;
        public int races
        {
            get
            {
                return _races;
            }
            set
            {
                _races = value;
            }
        }
        private int _points;
        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                _points = value;
            }
        }
        private int _wins;
        public int wins
        {
            get
            {
                return _wins;
            }
            set
            {
                _wins = value;
            }
        }
        private int _top5;
        public int top5
        {
            get
            {
                return _top5;
            }
            set
            {
                _top5 = value;
            }
        }
        private int _top10;
        public int top10
        {
            get
            {
                return _top10;
            }
            set
            {
                _top10 = value;
            }
        }
        private double _lapslead;
        public double lapslead
        {
            get
            {
                return _lapslead;
            }
            set
            {
                _lapslead = value;
            }
        }
        private double _avgfinish;
        public double avgfinish
        {
            get
            {
                return _avgfinish;
            }
            set
            {
                _avgfinish = value;
            }
        }
        private double _avgrate;
        public double avgrate
        {
            get
            {
                return _avgrate;
            }
            set
            {
                _avgrate = value;
            }
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
        #endregion
    }
}
