namespace Arrays
{
    public class FindDuplicate : IExecute
    {
        /// <summary>
        /// Greedy Approach - Set the nums[n] to its negative value.  
        /// Modifies the Input Array (Mutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int Find(int[] nums)
        {
            int n = nums.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int number = Math.Abs(nums[i]);

                if (nums[number] < 0)
                {
                    result = number;
                    break;
                }

                nums[number] = nums[number] * -1;
            }

            return result;
        }

        /// <summary>
        /// Tortoise & Hare (Floyd's Cycle Detection) Algorithm.  
        /// Doesn't modify the Input Array (Immutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static int FindOptimized(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];

            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];

            } while (slow != fast);

            fast = nums[0];

            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }

            return fast;
        }

        public void Execute()
        {
            Console.WriteLine("###########LeetCode###########");
            Console.WriteLine("287. Find the Duplicate Number");
            Console.WriteLine("Difficulty Level - MEDIUM");

            int[] test1DN = new int[] { 1, 3, 4, 2, 2 };
            int[] test2DN = new int[] { 1, 1, 2 };
            int[] test3DN = new int[] { 1, 1 };
            int[] test4DN = new int[] { 3, 1, 3, 4, 2 };

            Console.WriteLine("[{0}]", string.Join(", ", Find(test1DN)));
            Console.WriteLine("[{0}]", string.Join(", ", Find(test2DN)));
            Console.WriteLine("[{0}]", string.Join(", ", Find(test3DN)));
            Console.WriteLine("[{0}]", string.Join(", ", Find(test4DN)));
        }
    }
}
