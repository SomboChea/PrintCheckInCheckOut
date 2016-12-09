using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min2Hour
{
    public class min2HourMain
    {
        public string min2Hour(double mn)
        {
            int rH = 0;
            while (mn >= 60)
            {
                rH++;
                mn -= 60;
            }
           
            return rH + "h : " + mn + "mn";
        }

        public string min2Day(double mn)
        {
            int rD = 0, rH = 0;
            while (mn >= 60)
            {
                rH++;
                mn -= 60;
            }
            while (rH >= 24)
            {
                rD++;
                rH -= 24;
            }
            return rD + "d : " + rH + "h : " + mn + "mn";
        }
    }

    public class min2Timespan
    {
        public int tHour(double mn)
        {
            int rH = 0;
            while (mn >= 60)
            {
                rH++;
                mn -= 60;
            }
            return rH;
        }
        public int tMin(double mn)
        {
            int rMN = 0;
            while (mn >= 60)
            {
                mn -= 60;
            }
            rMN = int.Parse(mn + "");
            return rMN;
        }
    }
}
