public class Solution {
    public bool IsPalindrome(string s) {
        
        string clean = string.Concat(s.Where(char.IsLetterOrDigit)).ToLowerInvariant();

        int left = 0;

        for(int right = clean.Length -1; left <= right; right--){

            if(clean[left]!=clean[right]){
                return false;
            }

            left++;
        }

        return true;
    }
}
