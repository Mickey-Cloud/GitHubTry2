
static T FindMaxValue<T>(T[] array) where T : IComparable
{
    T maxValue = array[0];
    foreach(T a in array)
    {
        if (a.CompareTo(maxValue) > 0)
        {
            maxValue = a;
        }
    }
    return maxValue;
}

static T FindMinValue<T>(T[] array) where T : IComparable
{
    T minValue = array[0];
    foreach(T a in array)
    {
        if (a.CompareTo(minValue) < 0)
        {
            minValue = a;
        }
    }
    return minValue;
}

int[] arg = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine(FindMaxValue(arg));
Console.WriteLine(FindMinValue(arg));