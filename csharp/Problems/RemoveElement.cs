
namespace LeetCodeSolutions.Problems {
    public static class RemoveElement {
        public static int Remove(int[] nums, int val) {
            int count = 0;
            for(int i = 0; i < nums.Length; i++) {
                if(nums[i] == val) {
                    nums[i] = int.MaxValue;
                    count++;
                }
            }
            for(int write = 0; write < nums.Length; write++) {
                for(int sort = 0; sort < nums.Length - 1; sort++) {
                    if(nums[sort] > nums[sort + 1]) {
                        (nums[sort], nums[sort + 1]) = (nums[sort + 1], nums[sort]);
                    }
                }
            }
            return count;
        }
    }
}