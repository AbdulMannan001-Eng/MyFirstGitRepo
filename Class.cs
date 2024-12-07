namespace Algorithm;

public class Algorithms
{
    public static List<int> GetVowelPositions(string s)
    {
        List<int> vowelPositions = new List<int>();
        char[] vowels = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (s[i] == vowels[j])
                {
                    vowelPositions.Add(i);
                    // break;
                }
            }
        }

        return vowelPositions;
    }

    public static string ShiftLetters(string inputString)
    {
        char[] newChar = new char[inputString.Length];

        for (int a = 0; a < inputString.Length; a++)
        {
            char currentChar = inputString[a];

            if (currentChar >= 'a' && currentChar <= 'z')
            {
                newChar[a] = (currentChar == 'z') ? 'a' : (char)(currentChar + 1);
            }
            else if (currentChar >= 'A' && currentChar <= 'Z')
            {
                newChar[a] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 1);
            }
            else
            {
                newChar[a] = currentChar;
            }
        }
        return new string(newChar);
    }

    public static string TransformCase(string inputString)
    {
        char[] newChar = new char[inputString.Length];

        for (int a = 0; a < inputString.Length; a++)
        {
            char currentChar = inputString[a];

            if (currentChar >= 'a' && currentChar <= 'z')
            {
                newChar[a] = (currentChar == 'z') ? 'a' : (char)(currentChar - 32);
            }
            else if (currentChar >= 'A' && currentChar <= 'Z')
            {
                newChar[a] = (currentChar == 'Z') ? 'A' : (char)(currentChar + 32);
            }
            else
            {
                newChar[a] = currentChar;
            }
        }
        return new string(newChar);
    }
    // public static string ReplaceCharacter(string inputString, char c1, char c2)
    // for (nt [i] ==)
    
    // {
        
    // }
    public static string SwapPairs(string s)
    {
        char[] swapped = new char[s.Length];

        for (int i = 0; i < s.Length - 1; i += 2)
        {
            swapped[i] = s[i + 1];
            swapped[i + 1] = s[i];
        }

        if (s.Length % 2 != 0)
        {
            swapped[s.Length - 1] = s[s.Length - 1];
        }

        return new string(swapped);
    }

}

