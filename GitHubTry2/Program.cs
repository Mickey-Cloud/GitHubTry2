// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//please dont make me fail the lab
static void FindMaxValue<T>(T[] array)
{
    T MaxValue = array[0];
    foreach(T a in array)
    {
        if (a > MaxValue)
        {
            MaxValue = a;
        }
    }
    ///here is a comment
}