namespace LeetCodeSolutions.Problems {
    public class NumberOfSpecialCharacters {
        public int Solution(string word) {
            HashSet<char> seen = new();
            Dictionary<char, List<int>> dict = new();
            for(int i = 0; i < word.Length; i++) {
                if(char.IsLower(word[i])) continue;
                if(seen.Add(word[i])) {
                    dict.Add(word[i], new List<int>());
                    dict[word[i]].Add(i);
                    dict[word[i]].Add(word.LastIndexOf(char.ToLower(word[i])));
                }
            }

            return dict.Count(x => x.Value[1] != -1 && x.Value[0] > x.Value[1]);
        }

        public int CountPrefixSuffixPairs(string[] words) {
            var count = 0;
            for(int i = 0; i < words.Length; i++) {
                for(int j = i + 1; j < words.Length; j++) {
                    if(words[j].StartsWith(words[i]) && words[j].EndsWith(words[i])) {
                        count++;
                    }
                }
            }

            return count;
        }

        public int CountKeyChanges(string s) {
            var count = 0;
            for(int i = 0; i < s.Length - 1; i++) {
                if(char.ToLower(s[i]) != char.ToLower(s[i + 1])) {
                    count++;
                }
            }
            return count;
        }
        public bool IsSubstringPresent(string s) {
            for(int i = 0; i < s.Length-1; i++) {
                var st = new string(s.Substring(i, 2).Reverse().ToArray());
                if(s.Contains(st)) return true;
            }

            return false;
        }
    }
}