public class MinStack {

    private Stack<(int val, int min)> minStack;

    public MinStack() {

        minStack = new Stack<(int, int)>();

    }
    
    public void Push(int val) {
        if(minStack.Count == 0){

            minStack.Push((val, val));

        }
        else{

            int temp_min = minStack.Peek().min;

            minStack.Push((val, Math.Min(temp_min, val)));


        }
    }
    
    public void Pop() {
        minStack.Pop();
    }
    
    public int Top() {

        return minStack.Peek().val;

    }
    
    public int GetMin() {

        return minStack.Peek().min;

    }
}
