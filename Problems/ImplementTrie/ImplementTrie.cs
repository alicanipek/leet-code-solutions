public class Trie {
    TrieNode root = new TrieNode();
    
    public void Insert(string word) {
        Console.WriteLine(word);
        TrieNode current = root;
        for(int i = 0; i < word.Length; i++){
            Console.WriteLine(word[i] - 'a');
            
            int index = word[i] - 'a';
            if (current.children[index] == null)
                current.children[index] = new TrieNode();
     
            current = current.children[index];
        }
        
        current.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        int index;
        for(int i = 0; i < word.Length; i++){
            index = word[i] - 'a';
            if (current.children[index] == null)
                return false;
     
            current = current.children[index];
        }
        
        return current.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        int index;
        for(int i = 0; i < prefix.Length; i++){
            index = prefix[i] - 'a';
            if (current.children[index] == null)
                return false;
     
            current = current.children[index];
        }
        
        return true;
    }
}