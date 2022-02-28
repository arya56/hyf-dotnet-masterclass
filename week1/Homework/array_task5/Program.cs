// See https://aka.ms/new-console-template for more information

// int[] result = AddArray(splitArray);
// WriteResult(result);

int[] input = new[] { 1, 2, 5, 7, 2, 3, 5, 7 };
int[][] splitArray = Split(input);


int[][] Split(int[] inputArray)
{
    int[] firstArray = new int[] { };
    int[] secondArray = new int[] { };

    int[][] twoDimentionArray = new int[2][];
    if (inputArray.Length % 2 == 0)
    {
        for (var i = 0; i < inputArray.Length / 2; i++)
        {
            Console.WriteLine(inputArray[i]);
            firstArray[i] = inputArray[i];
        }
        for (var i = inputArray.Length / 2; i < inputArray.Length; i++)
        {
            secondArray[i] = inputArray[i];
        }
        twoDimentionArray[0] = firstArray;
        twoDimentionArray[1] = secondArray;
        foreach (var item in twoDimentionArray)
        {
            Console.WriteLine(item);
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
