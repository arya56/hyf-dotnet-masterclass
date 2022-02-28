// See https://aka.ms/new-console-template for more information

// int[] result = AddArray(splitArray);
// WriteResult(result);

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);

int[][] Split(int[] inputArray)
{
    int[] secondArray = { };
    int[][] twoDimentionArray = new int[2][];
    if (inputArray.Length % 2 == 0)
    {
        for (var i = 0; i < inputArray.Length / 2; i++)
        {
            Console.WriteLine(inputArray[i]);
            twoDimentionArray[0][i] = inputArray[i];
        }
        for (var i = inputArray.Length; i < inputArray.Length; i++)
        {
            twoDimentionArray[1][i] = inputArray[i];
        }
        //firstArray = inputArray.Take(4).ToArray();
        // secondArray=inputArray.Skip(inputArray.Length/2);
        // return firstArray,secondArray;
    }
    else
    {
        Console.WriteLine("Array lenght is not even");
    }
    return twoDimentionArray;
}
