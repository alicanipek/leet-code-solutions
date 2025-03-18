
namespace LeetCodeSolutions.Problems {
    public class HaystackNeedle {
        public int StrStr(string haystack, string needle) {
            int windowSize = needle.Length;

            for(int i = 0; i < haystack.Length - windowSize; i++) {
                string substr = haystack.Substring(i, windowSize);
                if(substr == needle) {
                    return i;
                }
            }

            return 0;
        }
    }
}