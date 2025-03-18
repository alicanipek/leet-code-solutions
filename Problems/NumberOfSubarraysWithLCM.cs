namespace LeetCodeSolutions.Problems {
    /*
     * Input: nums = [3,6,2,7,1], k = 6
       Output: 4
       Explanation: The subarrays of nums where 6 is the least common multiple of all the subarray's elements are:
       - [3,6,2,7,1]
       - [3,6,2,7,1]
       - [3,6,2,7,1]
       - [3,6,2,7,1]
     */
    public class NumberOfSubarraysWithLCM {
        public static int SubarrayLCM(int[] nums, int k) {
            int result = 0;
            for(int i = 0; i < nums.Length; i++) {
                var curr = nums[i];
                if(curr == k) result++;

                for(int j = i + 1; j < nums.Length; j++) {
                    var x = curr;
                    var y = nums[j];
                    curr = Lcm(x, y);
                    if(curr > k) break;
                    result += curr == k ? 1 : 0;
                }
            }

            return result;
        }

        private static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }

        private static int Gcd(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            return Gcd(b % a, a);
        }
    }
}