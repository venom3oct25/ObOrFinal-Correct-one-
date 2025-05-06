using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObOrFinal
{
    internal class footballplayer
    {
        //https://www.pro-football-reference.com/players/B/BailJo00.htm
        public static string footballlinkmaker(string nameinput)
        {
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
        //asdasd
    }
}
