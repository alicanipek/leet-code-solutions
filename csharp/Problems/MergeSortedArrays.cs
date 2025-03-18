
// 88. Merge Sorted Array

namespace LeetCodeSolutions.Problems {
    public class MergeSortedArrays {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            for(int x = 0; x < n; x++) {
                nums1[m + x] = nums2[x];
            }
            Sort(nums1);
        }

        private static void Print(int[] nums) {
            for(int i = 0; i < nums.Length; i++) {
                System.Console.WriteLine(nums[i]);
            }
        }

        private static void Sort(int[] nums) {
            for(int i = 0; i < nums.Length; i++) {
                for(int j = i + 1; j < nums.Length; j++) {
                    if(nums[i] > nums[j]){
                        var temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
    }
}