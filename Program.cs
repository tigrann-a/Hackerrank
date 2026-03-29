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

    int minNumber = 0;

    Console.WriteLine(minNumber);
    return 1;
}

int minNum = minimumNumber(3, "Ab1");