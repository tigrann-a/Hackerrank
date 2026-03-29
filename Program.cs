// 1.
//static string superReducedString(string s)
//{

//    int i = 0;
//    while (i + 1 < s.Length)
//    {
//        char current = s[i];
//        char next = s[i + 1];

//        if (current == next)
//        {
//            s = s.Remove(i, 2);
//            i = 0;
//            continue;
//        }
//        i++;
//    }

//    if (s.Length == 0)
//        return "Empty String";

//    return s;
//}

//string s = "aaabccddd";

//string s1 = superReducedString(s);
//Console.WriteLine(s1);

// 2.

//static int camelcase(string s)
//{
//    int count = 1;

//    for (int i = 1; i < s.Length; i++)
//    {
//        char temp = s[i];
//        temp = Char.ToUpper(temp);

//        if (s[i] == temp)
//            count++;
//    }

//    return count;

//}

//string s = "saveChangesInTheEditor";

//int wordCount = camelcase(s);
//Console.WriteLine(wordCount);

// 3.
static int minimumNumber(int n, string password)
{
    string numbers = "0123456789";
    string lower_case = "abcdefghijklmnopqrstuvwxyz";
    string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string special_characters = "!@#$%^&*()-+";

    int minSymbolsForTruePasswordLength = 0;
    int symbolsToAdd = 0;

    bool noMatches = false;

    for (int i = 0; i < password.Length; i++)
    {
        char currentSymbol = password[i];

        if (numbers.Contains(currentSymbol))
        {
            noMatches = false;
            break;
        }
        else
        {
            noMatches = true;
            continue;
        }
    }

    if (noMatches)
        symbolsToAdd += 1;

    for (int i = 0; i < password.Length; i++)
    {
        char currentSymbol = password[i];

        if (lower_case.Contains(currentSymbol))
        {
            noMatches = false;
            break;
        }
        else
        {
            noMatches = true;
            continue;
        }
    }

    if (noMatches)
        symbolsToAdd += 1;

    for (int i = 0; i < password.Length; i++)
    {
        char currentSymbol = password[i];

        if (upper_case.Contains(currentSymbol))
        {
            noMatches = false;
            break;
        }
        else
        {
            noMatches = true;
            continue;
        }
    }

    if (noMatches)
        symbolsToAdd += 1;

    for (int i = 0; i < password.Length; i++)
    {
        char currentSymbol = password[i];

        if (special_characters.Contains(currentSymbol))
        {
            noMatches = false;
            break;
        }
        else
        {
            noMatches = true;
            continue;
        }
    }

    if (noMatches)
        symbolsToAdd += 1;

    minSymbolsForTruePasswordLength = 6 - n;

    if(symbolsToAdd > minSymbolsForTruePasswordLength)
    {
        return symbolsToAdd;
    }

    return minSymbolsForTruePasswordLength;
}

int minNum = minimumNumber(3, "Ab1");
Console.WriteLine(minNum);