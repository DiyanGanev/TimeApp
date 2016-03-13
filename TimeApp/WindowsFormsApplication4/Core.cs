using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class Core 
    {
        IList<Class1> storage = new List<Class1>();
        public DateTime starTime;
        public DateTime endTime;
        public TimeSpan spendTime;

        public void Start()
        {
           
            starTime = DateTime.UtcNow;
        }
        public void End()
        {
            endTime = DateTime.UtcNow;
            spendTime = endTime.Subtract(starTime);
            storage.Add(new Class1(starTime, endTime, spendTime));

        }
        public string Info()
        {
            string x = "";
            foreach (Class1 g in storage)
            {
             x = g.Call() + "\n";   
            }
            return x;
        }
public TimeSpan Total()
        {
            TimeSpan x = new TimeSpan();
    foreach (Class1 g in storage)
            {
                x += g.spendTime;
            }

    return x; 
         
        }

    }
}
