string input = "there are snakes at the zoo";

Console.WriteLine(input);

//Console.WriteLine(ReverseWord("hola"));
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
       
    }
    return result;
}

string ReverseWord(string word)
{
    char[] wordtoChard = word.ToCharArray();
    Array.Reverse(wordtoChard);
    return new string(wordtoChard);
}