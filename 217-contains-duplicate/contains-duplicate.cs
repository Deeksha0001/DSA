
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        int n1 = nums.Length;
        HashSet<int> seen = new HashSet<int> ();
        for(int i=0; i<n1; i++)
        {
            seen.Add(nums[i]);
        }
        int n2 = seen.Count;
        if(n1 != n2)
        {
            return true;
        }
        return false;
    }
}

