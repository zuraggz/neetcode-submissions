public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new System.Text.StringBuilder();
        foreach (string item in strs) {
            sb.Append(item.Length).Append('#').Append(item);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length) {
            int j = i;
            while (s[j] != '#') j++;

            int length = int.Parse(s.Substring(i, j - i));
            result.Add(s.Substring(j + 1, length));

            i = j + 1 + length;
        }
        return result;
    }
}