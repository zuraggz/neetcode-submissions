public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, int> frequency = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (frequency.ContainsKey(num))
                frequency[num] += 1;
            else
                frequency[num] = 1;
        }

      
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in frequency) {
            int element = pair.Key;
            int freq = pair.Value;

            if (buckets[freq] == null)
                buckets[freq] = new List<int>();

            buckets[freq].Add(element);
        }

        
        int[] answer = new int[k];
        int index = 0;

        for (int i = buckets.Length - 1; i > 0; i--) {
            if (buckets[i] == null)
                continue;

            foreach (int element in buckets[i]) {
                answer[index] = element;
                index++;

                if (index == k)
                    return answer;
            }
        }

        return answer;
    }
}