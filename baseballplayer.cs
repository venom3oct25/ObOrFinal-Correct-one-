using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObOrFinal
{
    internal class baseballplayer
    {
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
    }
}
