namespace DataStructures.Algorithms.Strings
{
    public class TimeDifference : IExecute
    {
        /// <summary>
        /// Time Difference
        /// </summary>
        /// Time Complexity: O(1)
        /// Space complexity: O(1)
        public static string TimeGap(string t1, string t2)
        {
            var t1sec = GetSeconds(t1);
            var t2sec = GetSeconds(t2);

            int timeDiff = Math.Abs(t1sec - t2sec);

            int hours = timeDiff / 3600;
            int minutes = timeDiff % 60;
            int seconds = timeDiff % 60;

            string hh = hours > 0 && hours == 1 ? hours + " hour" : hours + " hours";
            string mm = minutes > 10 && minutes == 1 ? minutes + " minute" : seconds + " minutes";
            string ss = seconds > 10 && seconds == 1 ? seconds + " second" : seconds + " seconds";

            return string.Format("{0}:{1}:{2}", hh, mm, ss);
        }

        private static int GetSeconds(string time)
        {
            string[] timeString = time.Split(':');
            int seconds = Int32.Parse(timeString[0]) * 60 * 60 +
                    Int32.Parse(timeString[1]) * 60 +
                    Int32.Parse(timeString[2]);

            return seconds;
        }

        public void Execute()
        {
            Console.WriteLine("###Hacker Earth###");
            Console.WriteLine("Time Difference");

            string t1 = "13:50:45";
            string t2 = "14:55:50";

            Console.WriteLine("[{0}]", TimeGap(t1, t2));
        }
    }
}
