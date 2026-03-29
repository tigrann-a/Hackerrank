static string superReducedString(string s)
{
    for (int i = 0; i < s.Length; i++)
    {
        char current = s[i];

        if(i + 1 <= s.Length - 1)
        {
            char next = s[i + 1];

            if (current == next)
            {
                s = s.Remove(i, 2);
                i = 0;
            }
        }
    }

    return s;
}

string s = "aaaabccddd";

string s1 = superReducedString(s);
Console.WriteLine(s1);