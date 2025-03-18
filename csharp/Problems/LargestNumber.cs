namespace LeetCodeSolutions.Problems {
    public class LargestNumber {
    	private static int Compare(string x, string y) {
    		if(x == null) {
    			if(y == null) {
    				return 0;
    			} else {
    				return -1;
    			}
    		} else {
    			if(y == null) {
    				return 1;
    			} else {
    				string xr = x + y;
    				string yr = y + x;

    				return xr.CompareTo(yr);
    			}
    		}
    	}
    	public static string Solution(int[] nums) {
    		var s = nums.Select(x => x.ToString()).ToList();
    		s.Sort(Compare);
    		s.Reverse();
    		var res = string.Join("", s);
    		return res.All(x => x.Equals('0')) ? "0" : res;
    	}
    }
}
