public class Solution {
    public int EvalRPN(string[] tokens) {
        
        Stack<int> numbers = new Stack<int>();

        foreach(string token in tokens){
            if (token == "+" || token == "-" || token == "*" || token == "/"){
                
                int b = numbers.Pop();
                int a = numbers.Pop();
                

                numbers.Push(token switch{
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                });
            }
            else{
                numbers.Push(int.Parse(token));
            }
        }

        return numbers.Pop();

    }
}
