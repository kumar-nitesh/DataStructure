namespace DataStructures.Algorithms.Arrays
{
    public class FindAllDuplicates : IExecute
    {
        /// <summary>
        /// Greedy Approach - Set the nums[n] to its negative value.  
        /// Modifies the Input Array (Mutable Array).
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> Find(int[] nums)
        {
            List<int> result = new List<int>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                nums[nums[i] % n] = nums[nums[i] % n] + n;
            }

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > n * 2)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        /// <summary>
        /// The input array can be used as a HashMap. While Traversing the array, 
        /// if an element ‘a’ is encountered then increase the value of a%n‘th element by n. 
        /// The frequency can be retrieved by dividing the a % n’th element by n.
        /// </summary>
        /// Time Complexity: O(n)
        /// Space complexity: O(1)
        public static IList<int> Optimized(int[] nums)
        {
            List<int> result = new List<int>();
            int n = nums.Length;

            for (int i = 0; i < n; i++)
            {
                int number = Math.Abs(nums[i]) - 1;

                if (nums[number] < 0)
                {
                    result.Add(number + 1);
                }

                nums[number] = nums[number] * -1;
            }

            return result;
        }

        public void Execute()
        {
            Console.WriteLine("##############LeetCode##############");
            Console.WriteLine("442. Find All Duplicates in an Array");
            Console.WriteLine("Difficulty Level - MEDIUM");

            int[] t1 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] t2 = new int[] { 1, 1, 2 };
            int[] t3 = new int[] { 2 };
            int[] t4 = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            int[] t5 = new int[] { 1, 1, 2 };
            int[] t6 = new int[] { 2, 2 };

            var r1 = FindAllDuplicates.Find(t1);
            Console.WriteLine("[{0}]", string.Join(", ", r1));

            var r2 = FindAllDuplicates.Find(t2);
            Console.WriteLine("[{0}]", string.Join(", ", r2));

            var r3 = FindAllDuplicates.Find(t3);
            Console.WriteLine("[{0}]", string.Join(", ", r3));

            var r4 = FindAllDuplicates.Optimized(t4);
            Console.WriteLine("[{0}]", string.Join(", ", r4));

            var r5 = FindAllDuplicates.Optimized(t5);
            Console.WriteLine("[{0}]", string.Join(", ", r5));

            var r6 = FindAllDuplicates.Optimized(t6);
            Console.WriteLine("[{0}]", string.Join(", ", r6));
        }
    }
}
