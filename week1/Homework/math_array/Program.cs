// See https://aka.ms/new-console-template for more information

int[] arr = new[] { 271, -3, 1, 14, -100, 13, 2, 1, -8, -59, -1852, 41, 5 };
int[] result = GetResult(arr); //TODO: Implement GetResult
Console.WriteLine($"Sum of negative numbers: {result[0]}. Multiplication of positive numbers: {result[1]}");

int[] GetResult(int[] array)
{
    int sum = 0;
    int multiple = 1;
    var resultArray = new int[2];
    foreach (var element in array)
    {
        if (element > 0)
        {
            sum += element;
        }
        else
        {
            multiple *= element;
        }
    }
    resultArray[0] = sum;
    resultArray[1] = multiple;
    return resultArray;
}