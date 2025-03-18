namespace LeetCodeSolutions.Problems {
    public class IntervalBetweenIdenticalElements {
    	public static long[] GetDistances(int[] arr) {
    		Dictionary<int, List<long>> d = new Dictionary<int, List<long>>();
    		for(int i = 0; i < arr.Length; i++) {
    			if(d.ContainsKey(arr[i])) {
    				d[arr[i]].Add(i - d[arr[i]].ElementAt(0));
    			} else {
    				d[arr[i]] = new List<long> { i };
    			}
    		}

    		var res = arr.Select(x => {
    			d[x][0] = 0;
    			return d[x].Sum();
    		});
    		return res.ToArray();

    	}
    }
}
