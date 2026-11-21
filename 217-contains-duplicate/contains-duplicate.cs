public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        // int n1 = nums.Length;
        // HashSet<int> seen = new HashSet<int>();
        // for(int i=0; i<n1; i++)
        // {
        //     if(seen.Contains(nums[i]))
        //     {
        //         return true;
        //     }
        //     seen.Add(nums[i]);
        // }
        // return false;
        HashSet<int> set = new HashSet<int>(nums);
        return nums.Length != set.Count;
    }
}