//leetcode  question number 1528

public class StringShuffle {
    public string RestoreString(string s, int[] indices) {
        int len = indices.Length;
        char[] ch = new char[len];
       for(int i = 0; i<len;i++)
       {
            ch[indices[i]] = s[i];
       }
        return new String(ch);
    }
}