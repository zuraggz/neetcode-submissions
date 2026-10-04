public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        foreach(string word in strs){
            int[] count = new int[26];

            foreach(char c in word){

                count[c - 'a'] +=1;

            }

            StringBuilder sb = new();

            for(int i =0; i < 26; i++){
                sb.Append("#");
                sb.Append(count[i]);
            }

            string key = sb.ToString();

            if(!dict.ContainsKey(key)){
                dict[key] = new List<string>();

            }

            dict[key].Add(word);

        }

        return new List<List<string>>(dict.Values);

    }
}
