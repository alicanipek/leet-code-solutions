namespace LeetCodeSolutions.Problems {
    public class SmallestValue {
        public int Solve(int n) {
            var list = new List<int>();
            for(int i = 2; i <= n; i++){
                while(n % i == 0){
                    n /= i;
                    list.Add(i);
                }
            }
            if(list.Count == 1) return list[0];
            var result = list.Sum();
            return Solve(result);
        }
    }
}