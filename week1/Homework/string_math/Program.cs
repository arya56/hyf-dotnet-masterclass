// See https://aka.ms/new-console-template for more information
string input = "Intellectualization";
int vowelCount = GetVowelCount(input); //TODO: Implement GetVowelCount 
Console.WriteLine($"Number of vowels: {vowelCount}");
int GetVowelCount(string inputWord)
{
    inputWord = inputWord.ToLower();
    char[] word = inputWord.ToCharArray();
    char[] vowels = "aeiou".ToCharArray();
    int counter = 0;
    foreach (var vowel in vowels)
    {
        foreach (var charOfWord in word)
        {
            if (charOfWord == vowel)
            {
                counter++;
            }
        }
    }
    return counter;
}