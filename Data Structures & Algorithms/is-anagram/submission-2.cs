public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict_s = new Dictionary<char, int>();
        Dictionary<char, int> dict_t = new Dictionary<char, int>();

        foreach(char c in s){
            if(dict_s.ContainsKey(c)){
                dict_s[c]++;
            }
            else{
                dict_s[c]=1;
            }
        }
        foreach(char c in t){
            if(dict_t.ContainsKey(c)){
                dict_t[c]++;
            }
            else{
                dict_t[c]=1;
            }
        }

        if (dict_s.Count != dict_t.Count) {
            return false;
        }
        
        foreach(var pair in dict_s){
            if(!dict_t.TryGetValue(pair.Key, out int count) || count!=pair.Value){
                return false;
            }
        }

        return true;
    }
}
