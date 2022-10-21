public class TrieNode
{
    public TrieNode[] children = new TrieNode[26];

    // isEndOfWord is true if the node represents
    // end of a word
    public bool isEndOfWord;

    public TrieNode()
    {
        isEndOfWord = false;
        for (int i = 0; i < 26; i++)
            children[i] = null;
    }
};