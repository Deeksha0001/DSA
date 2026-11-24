public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        // int[] count = new int[26];
        // foreach(char ch in s){
        //     count[ch - 'a']++;
        // }
        // foreach(char ch in t){
        //     count[ch - 'a']--;
        // }
        // foreach(int num in count){
        //     if(num != 0){
        //         return false;
        //     }
        // }
        // return true;
        Dictionary<char, int> count = new Dictionary<char, int>();
        foreach(char ch in s){
            if(!count.ContainsKey(ch)){
                count[ch] = 0;
            }
            count[ch]++;
        }
        foreach(char ch in t){
            if(!count.ContainsKey(ch)){
                return false;
            }
            count[ch]--;
            if(count[ch] < 0){
                return false;
            }
        }
        return true;
    }
}