namespace Clock
{
    class Program
    {

        public static void TellTime(IClock clock)
        {
            clock.GetTime();
        }

        static void Main()
        {
            int tick = 7;

            IClock analog = new AnalogToTime(18, 36);
            IClock digital = new DigitalToTime(18, 36);

            for (int i = 0; i <= 24 * 60 / Math.Abs(tick); i++)
            {
                TellTime(analog);
                TellTime(digital);
                analog.TickMin(tick);
                digital.TickMin(tick);
                Console.WriteLine();
            }
        }
    }
}