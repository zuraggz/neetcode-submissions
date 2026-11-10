public class Solution {
    public bool IsValid(string s) {

        Stack<char> comparable = new Stack<char>();

        foreach (char parentheses in s) {

            if (parentheses == '{') {
                comparable.Push('}');
            }
            else if (parentheses == '(') {
                comparable.Push(')');
            }
            else if (parentheses == '[') {
                comparable.Push(']');
            }
            else {
                if (comparable.Count == 0 || comparable.Pop() != parentheses) {
                    return false;
                }
            }
        }

        return comparable.Count == 0;
    }
}