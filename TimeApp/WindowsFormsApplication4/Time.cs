using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Time
    {
        public DateTime starTime;
        public DateTime endTime;
        public TimeSpan spendTime;
        public Time(DateTime s, DateTime e, TimeSpan d)
        {
            this.starTime = s;
            this.endTime = e;
            this.spendTime = d;
        }
        public string Call()
        {
            string x;
            x = "Start:" + starTime.ToString("HH:mm:ss");
            x += "End" + endTime.ToString("HH:mm:ss");
            x += "Eclapsed" + spendTime.ToString(@"hh\:mm\:ss");
            return x;
        }

    }
}
