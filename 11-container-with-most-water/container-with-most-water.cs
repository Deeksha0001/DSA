public class Solution {
    public int MaxArea(int[] height) {
        int maxWater = 0;
        int lp = 0, rp = height.Length-1;
        while(lp<rp){
            int w = rp-lp;
            int ht = Math.Min(height[lp], height[rp]);
            int currWater = w*ht;
            maxWater = Math.Max(maxWater, currWater);
            if(height[lp] < height[rp])
            lp++ ;
            else rp--;
        }
        return maxWater;
    }
}