namespace Strings
{
    public class AddBinary : IExecute
    {
        /// Time Complexity: O(max(L1, L2))
        /// Space Complexity: O(max(L1, L2)) 
        /// where L1 and L2 are the lengths of strings a and b respectively.
        public static string Add(string a, string b)
        {
            string result = string.Empty;
            int i = a.Length - 1;
            int j = b.Length - 1;
            int sum = 0;

            while (i >= 0 || j >= 0 || sum == 1)
            {
                sum += (i >= 0) ? a[i] - '0' : 0;
                sum += (j >= 0) ? b[j] - '0' : 0;

                // Sum Logic
                // 0 + 0 => 0 % 2 = 0
                // 0 + 1 => 1 % 2 = 1
                // 1 + 0 => 1 % 2 = 1
                // 1 + 1 => 2 % 2 = 0
                result = (char)(sum % 2 + '0') + result;

                // Carry Logic(sum/2)
                // 0/2 = 0
                // 1/2 = 0
                // 2/2 = 1
                sum /= 2;

                i--;
                j--;
            }

            return result;
        }

        public void Execute()
        {
            var result1 = Add("11", "1");
            Console.WriteLine("[{0}]", string.Join(", ", result1));

            var result2 = Add("1010", "1011");
            Console.WriteLine("[{0}]", string.Join(", ", result2));
        }
    }
}
