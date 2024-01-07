public class Solution
{
    public int CountOne(uint n)
    {
    
        string numeroBinario = Convert.ToString(n, 2);  

        if (numeroBinario.Length == 1)
            return n == 1U ? 1 : 0;

        int left = 0;
        int right = numeroBinario.Length - 1;
        int mid = left + (right - left) / 2;

        string leftPart = numeroBinario.Substring(left, mid+1);
        string rightPart = numeroBinario.Substring(mid+1, right - mid);

        return CountOne(Convert.ToUInt32(leftPart, 2)) + CountOne(Convert.ToUInt32(rightPart, 2));
    }

    public int HammingWeight(uint n)
    {
        return CountOne(n);
    }
}
