public class Solution
{
    //way 1
    public bool CheckIfExist1(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == 2 * arr[j] || 2 * arr[i] == arr[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
    // way 2
    public bool CheckIfExist(int[] arr)
    {
        HashSet<int> map = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (map.Contains(arr[i] * 2) || (arr[i] % 2 == 0 && map.Contains(arr[i] / 2)))
            {
                return true;
            }
            else
            {
                map.Add(arr[i]);
            }
        }
        return false;
    }
}