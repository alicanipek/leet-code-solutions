public class ValidAnagram {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var sarr = s.ToList();
        var tarr = t.ToList();
        for(int i = 0; i < sarr.Count; i++) {
            tarr.Remove(sarr[i]);
        }
        return tarr.Count == 0;
    }
}
