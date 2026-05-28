public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>(nums.Length);
        for(int i=0; i<nums.Length; i++){
            int complement = target-nums[i];
            if(map.TryGetValue(complement, out int index)){
                return new int[] {index, i};
            }
            if(!map.ContainsKey(nums[i]));
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}