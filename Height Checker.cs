public int HeightChecker(int[] heights)
{
    int count = 0;
    int[] expected = heights.OrderBy(x => x).ToArray();

    for (int i = 0; i < heights.Length; i++)
    {
        if (heights[i] != expected[i])
        {
            count++;
        }
    }

    return count;
}