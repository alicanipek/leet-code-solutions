public class MinimumRecolors {
    public static int Solve(string blocks, int k) {
        if(k == 1 && blocks.Contains('B')) return 0;
        int left = 0;
        int whites = 0;
        int recolor = int.MaxValue;
        while(left + k <= blocks.Length) {
            var s = blocks.Substring(left, k);
            whites = s.Where(x => x.Equals('W')).Count();
            recolor = Math.Min(whites, recolor);
            left++;
        }
        return recolor;

    }
}