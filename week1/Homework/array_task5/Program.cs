// See https://aka.ms/new-console-template for more information
int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);
AddArray(splitArray);
int[] result = AddArray(splitArray);
WriteResult(result);

int[][] Split(int[] inputArray)
{
    //     if (inputArray.Length%2!=0){
    //         int[][] result= new int [][]{};
    //         Console.WriteLine(result.Length);
    //             return new int[][] { };
    //     }
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
    foreach (int value in result)
    {
        Console.WriteLine(value);
    }

}