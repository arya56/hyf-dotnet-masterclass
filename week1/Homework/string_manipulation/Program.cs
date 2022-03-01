// See https://aka.ms/new-console-template for more information
string input = "world";
string reversed = ReverseString(input); //TODO: Implement ReverseString
Console.WriteLine($"Reversed input value: {reversed}");

string ReverseString(string inputWord)
{
    char[] wordArray = inputWord.ToCharArray();
    Console.WriteLine(wordArray);
    Array.Reverse(wordArray);
    return new string(wordArray);
}
