namespace Arrays
{
    public class Farthest : IExecute
    {
        public static int ElementFromZero(int[] nums)
        {
            int best = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (Math.Abs(nums[i]) > Math.Abs(best))
                {
                    best = nums[i];
                }
                else if (Math.Abs(best) == Math.Abs(nums[i]) && best > nums[i])
                {
                    best = nums[i];
                }
            }

            return best;
        }

        public void Execute()
        {
            int[] sample1 = new int[] { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine("########Hacker Earth##########");
            Console.WriteLine("Farthest from 0");
            Console.WriteLine("[{0}]", string.Join(", ", ElementFromZero(sample1)));
            Console.WriteLine("##########################################");
        }
    }
}
