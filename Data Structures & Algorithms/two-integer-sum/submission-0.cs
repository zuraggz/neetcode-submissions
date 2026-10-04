public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> dict = new Dictionary<int, int>();

        int[] result = new int[2] {-1,-1}; 

        for(int i = 0; i < nums.Length; i++){

            if(dict.ContainsKey(target-nums[i])){
                result[0] = dict[target-nums[i]];
                result[1] = i;
                return result;
            }

            else{
                dict[nums[i]] = i;
            }
        }

        return result;

    }
}


// Dict = {3:0 , 4:1, 5:2, 6:3}