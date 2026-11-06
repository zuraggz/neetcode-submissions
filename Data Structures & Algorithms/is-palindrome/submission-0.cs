public class Solution {
    public bool IsPalindrome(string s) {

        string word = string.Concat(s.Where(char.IsLetterOrDigit)).ToLowerInvariant();




        int left = 0;

        for(int right = word.Length-1; left <= right; right--){
            

            if(word[left]!=word[right]){

                return false;

            }

            left++;

        }

        return true;
    }
}
