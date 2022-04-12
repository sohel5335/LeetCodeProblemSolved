public int ThirdMax(int[] nums)
{
    int? max = null;
    int? seconnmax = null;
    int? third = null;

    foreach (var num in nums)
    {
        if (num.Equals(max) || num.Equals(seconnmax) || num.Equals(third))
        {
            continue;
        }
        if (max < num || max is null)
        {
            third = seconnmax;
            seconnmax = max;
            max = num;
        }
        else if (seconnmax < num || seconnmax is null)
        {
            third = seconnmax;
            seconnmax = num;
        }
        else if (third < num || third is null)
        {
            third = num;
        }
    }

    if (third == null)
        return max.Value;

    return third.Value;
}