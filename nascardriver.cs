using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObOrFinal
{
    internal class nascardriver
    {
        /*NascarDriver:
Stores the name of driver, their stats, and the code to compare changes for nascar drivers*/
        public void fillstats(string hatedriver){
            Console.WriteLine("WOAH");
            string pulledtext = Convert.ToString(HTMLdata.nascarfind(hatedriver));
            Console.WriteLine(pulledtext+ "adad");
            Console.WriteLine(pulledtext +" ad afbdfjfdojn");
            Console.WriteLine(pulledtext);
            Console.WriteLine("double or not");
            /*string[] parts = pulledtext.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            _name = parts[0] + " " + parts[1]; // This combines first and last name

            
            _avgfinish = double.Parse(parts[2]);
            _races = int.Parse(parts[3]);
            _wins = int.Parse(parts[4]);
            _top5 = int.Parse(parts[5]);
            _top10 = int.Parse(parts[6]);
            _lapslead = double.Parse(parts[7]);*/
        }
        public void compare()
        {
            //letters are placehold for old stats
            int a = 16; int b = 5; int c = 1; int d = 1; int e = 3; int f = 3;
            if(a < _avgfinish)
            {
                Console.WriteLine("bad change");
            }
            else
            {
                Console.WriteLine("Good Change");
            }
            if (b > _races)
            {
                Console.WriteLine("bad change");
            }
            else
            {
                Console.WriteLine("Good Change");
            }
            if (c > _wins)
            {
                Console.WriteLine("bad change");
            }
            else
            {
                Console.WriteLine("Good Change");
            }
        }

        #region Stats
      

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
