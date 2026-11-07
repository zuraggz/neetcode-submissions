public class Solution {
    public int MaxArea(int[] heights) {
        
        int answer = 0;

        int left = 0;
        
        int right = heights.Length-1;

        while(left < right){

            if(heights[left] > heights[right]){

                int candidate = heights[right] * (right-left);
                
                if(candidate > answer){

                    answer = candidate;

                }

                else{

                    right--;

                }


            }

            else{

                int candidate = heights[left] * (right-left);
                
                if(candidate > answer){

                    answer = candidate;

                }

                else{

                    left++;

                }
            }

            
            
        }

        return answer;

    }
}
