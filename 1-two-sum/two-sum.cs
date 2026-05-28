public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new ();
        for(int i=0; i<nums.Length; i++){
            int need = target - nums[i];
            if(map.TryGetValue(need, out int index)){
                return new int[] {index, i};
            }
            map[nums[i]] = i;
        }
        return Array.Empty<int>();
    }
}