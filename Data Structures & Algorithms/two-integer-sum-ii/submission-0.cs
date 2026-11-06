public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        Dictionary<int, int> outcomes = new Dictionary<int, int>();

        int[] answer = [-1, -1];

        for(int i = 0; i<numbers.Length; i++){

            if(outcomes.ContainsKey(target - numbers[i])){

                answer[0] = outcomes[target - numbers[i]]+1;
                answer[1] = i+1;
                return answer;

            }

            else{

                outcomes[numbers[i]] = i;

            }

        }

        return  answer;
        

    }
}
