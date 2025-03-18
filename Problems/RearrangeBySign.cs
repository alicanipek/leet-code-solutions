namespace LeetCodeSolutions.Problems {
    public class RearrangeBySign
    {
        public int[] RearrangeArray(int[] nums) {
            int[] pos = nums.Where(x => x > 0).ToArray();
            int[] neg = nums.Where(x => x < 0).ToArray();
    		var res = new List<int>();
    		int i = Math.Min(pos.Length, neg.Length);
    		int x = 0;
    		while (x < i)
    		{
    			res.Add(pos[x]);
    			res.Add(neg[x]);
    			x++;
    		}
    		return res.ToArray();

        }
    }
}
