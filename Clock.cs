using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class AnalogClock
    {
        int hourHand = 0;
        int HourHand { get { return hourHand; }
            set
            {
                while (value < 0)
                    value += 360;
                while (value >= 360)
                    value -= 360;
                hourHand = value;
            }
        }
        int minHand = 0;
        int MinHand
        {
            get { return minHand; }
            set
            {
                while (value < 0)
                {
                    value += 360;
                    HourHand -= 30;
                }
                while (value >= 360)
                {
                    value -= 360;
                    HourHand += 30;
                }
                minHand = value;
            }
        }


        protected AnalogClock(int hoursHand = 0, int minuteHand = 0)
        {
            HourHand = hoursHand;
            MinHand = minuteHand;
        }

        protected void Clockface()
        {
            //string pm = IsPM ? "pm" : "am";
            Console.WriteLine($"Аналоговые часы показывают {HourHand / 30:D2}:{MinHand / 6:D2}, отклонения стрелок {HourHand} и {MinHand}");
        }

        protected void Tick(int angle)
        {
            MinHand += angle;
        }
    }

    public class AnalogToTime(int hours = 0, int minutes = 0) : AnalogClock(hours * 30, minutes * 6), IClock
    {
        public void GetTime()
        {
            Clockface();
        }

        public void TickMin(int min)
        {
            Tick(min * 6);
        }
    }
}
