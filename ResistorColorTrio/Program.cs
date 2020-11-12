using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResistorColorTrio
{

    //Black: 0
    //Brown: 1
    //Red: 2
    //Orange: 3
    //Yellow: 4
    //Green: 5
    //Blue: 6
    //Violet: 7
    //Grey: 8
    //White: 9

    //The third color stands for how many zeros need to be added to the main value.
    //The main value plus the zeros gives us a value in ohms.For the exercise it doesn't matter what ohms really are. For example:
    //        orange-orange-black would be 33 and no zeros, which becomes 33 ohms.
    //        orange-orange-red would be 33 and 2 zeros, which becomes 3300 ohms.
    //        orange-orange-orange would be 33 and 3 zeros, which becomes 33000 ohms.



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Label(new string[] { "red", "black", "red" }));
        }
        public static string Label(string[] colors)
        {
            string value = "";
            Dictionary<string, int> resistanceCode = new Dictionary<string, int>()
        {
            {"black", 0},
            {"brown", 1},
            {"red", 2},
            {"orange", 3},
            {"yellow", 4},
            {"green", 5},
            {"blue", 6},
            {"violet", 7},
            {"grey", 8},
            {"white", 9}
        };

            value = (10 * resistanceCode[colors[0]] + resistanceCode[colors[1]]).ToString() + Math.Pow(10, resistanceCode[colors[2]]).ToString().Substring(1);

            if (int.Parse(value) >= 1000)
            {
                return int.Parse(value)/1000 + " kiloohms";
            }
            else return  value + " ohms";
        }
    }
}
