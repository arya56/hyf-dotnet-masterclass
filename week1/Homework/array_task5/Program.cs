// See https://aka.ms/new-console-template for more information
int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
if (input.Length % 2 != 0)
{

    Console.WriteLine("Array's length is not even");

}
else
{
    int[][] splitArray = Split(input);
    AddArray(splitArray);
    int[] result = AddArray(splitArray);
    WriteResult(result);
}


int[][] Split(int[] inputArray)
{
    int[] firstArray = new int[inputArray.Length / 2];
    int[] secondArray = new int[inputArray.Length / 2];
    Array.Copy(inputArray, firstArray, inputArray.Length / 2);
    Array.Copy(inputArray, inputArray.Length / 2, secondArray, 0, inputArray.Length / 2);
    return new int[][] { firstArray, secondArray };
}

int[] AddArray(int[][] twoArray)
{
    int[] result = new int[twoArray[0].Length];
    Array.Copy(twoArray[0], result, twoArray[0].Length - 1);
    for (var i = 0; i < twoArray[0].Length; i++)
    {
        result[i] += twoArray[1][i];
    }
    return result;
}

void WriteResult(int[] result)
{
    Console.WriteLine($"The following arrays: [{string.Join(", ", Split(input)[0])}] and [{string.Join(", ", Split(input)[1])}] Sum up in [{string.Join(", ", result)}]");


}