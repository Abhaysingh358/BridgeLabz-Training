public class LeetCode961 {
    public int RepeatedNTimes(int[] nums) {
        int [] Freq = new int[10001];
        foreach(int i in nums)
        {
            Freq[i]++;
            if(Freq[i]>1)
            {
                return i;
            }
        }
        return 0;
    }
}