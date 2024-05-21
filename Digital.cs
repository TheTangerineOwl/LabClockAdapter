using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class DigitalClock
    {
        int hh = 0;
        int HH
        {
            get { return hh; }
            set
            {
                while (value < 0)
                    value += 24;
                while (value >= 24)
                    value -= 24;
                hh = value;
            }
        }
        int mm = 0;
        int MM
        {
            get { return mm; }
            set
            {
                while (value < 0)
                {
                    value += 60;
                    HH--;
                }
                while (value >= 60)
                {
                    value -= 60;
                    HH++;
                }
                mm = value;
            }
        }

        public DigitalClock(int hours = 0, int minutes = 0)
        {
            HH = hours;
            MM = minutes;
        }

        protected void PrintDigital()
        {
            Console.WriteLine($"Цифровые часы показывают {HH:D2}:{MM:D2}");
        }

        protected void Tick(int minutes)
        {
            MM += minutes;
        }
    }

    public class DigitalToTime(int hours = 0, int minutes = 0) : DigitalClock(hours, minutes), IClock
    {
        public void GetTime()
        {
            PrintDigital();
        }

        public void TickMin(int min)
        {
            Tick(min);
        }
    }
}
