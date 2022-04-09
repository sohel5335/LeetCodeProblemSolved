public bool ValidMountainArray(int[] arr)
{
    if (arr.Length < 3)
        return false;
    int i = 0;

    while (i < arr.Length - 1)
    {
        if (arr[i] == arr[i + 1])
        {
            return false;
        }
        else if (arr[i] > arr[i + 1])
            break;
        i++;
    }
    if ((i == arr.Length - 1 && arr[arr.Length - 2] <= arr[arr.Length - 1]) || i == 0)
        return false;
    while (i < arr.Length - 1)
    {
        if (arr[i] <= arr[i + 1])
            return false;
        i++;
    }

    return true;
}