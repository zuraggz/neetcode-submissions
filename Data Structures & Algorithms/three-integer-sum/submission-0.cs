public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {

        List<List<int>> answers = new List<List<int>>();

        Array.Sort(nums);                         // 1

        for (int i = 0; i < nums.Length; i++) {

            if (i > 0 && nums[i] == nums[i - 1]) { // 2
                continue;
            }

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right) {

                if (nums[i] + nums[left] + nums[right] > 0) {
                    right--;
                }
                else if (nums[i] + nums[left] + nums[right] < 0) {
                    left++;
                }
                else {
                    List<int> answer = new List<int>() { nums[i], nums[left], nums[right] };
                    answers.Add(answer);
                    left++;
                    
                    while(left < right && nums[left]==nums[left-1]){
                        left++;
                    }
                    
                }
            }
        }

        return answers;                           // 4
    }
}