using System.Text;

static string StringToReverse(string newString)
{
    //string newString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
    string[] words = newString.Split(' ');
    StringBuilder sb = new StringBuilder();
    foreach (string word in words)
    {
        sb = sb.Insert(0, word + " ");
    }

    sb.Replace(".", "");
    sb.Replace(",", "");
    string result = sb.ToString();
    return result.ToLower();
}

static int StringToInt(string myStr)
{
    char[] x = new char[myStr.Length];
    int[] ints = new int[myStr.Length];
    int result = 0;
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = myStr[i];
    }

    for (int i = 0; i < x.Length; i++)
    {
        result *= 10;
        if (!((int)x[i] >= 48 && (int)x[i] <= 57)) throw new Exception($"{x[i]} is not a number");

        ints[i] = (int)x[i] - 48;
        result += ints[i];
    }


    return result;
}

static string[] SplitString(string sentence, char symbol)
{
    List<string> result = new();
    StringBuilder words = new StringBuilder();

    for (int i = 0; i < sentence.Length; i++)
    {
        if (sentence[i] != symbol || i == sentence.Length - 1)
        {
            words.Append(sentence[i]);
        }
        else
        {
            result.Add(words.ToString());
            words.Clear();
        }
    }

    result.Add(words.ToString());

    return result.ToArray();
}


Console.WriteLine(StringToReverse("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."));
Console.WriteLine(StringToInt("123"));
string sentences = "hi my name is";
char splitter = ' ';
foreach (var sentence in SplitString(sentences, splitter))
{
    Console.Write(sentence);
}