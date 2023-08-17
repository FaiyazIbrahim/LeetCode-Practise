public class Solution345
{
    public string ReverseVowels(string s)
    {
        List<char> vowels = new List<char>();
        List<int> vowelsFromStringASCII = new List<int>();
        vowels.Add('a');
        vowels.Add('e');
        vowels.Add('i');
        vowels.Add('o');
        vowels.Add('u');
        vowels.Add('A');
        vowels.Add('E');
        vowels.Add('I');
        vowels.Add('O');
        vowels.Add('U');
        
        string result = "";
        

        for (int i = 0; i < s.Length; i++)
        {
            if (IsVowel(s[i]))
            {
                vowelsFromStringASCII.Add((int)s[i]);
            }
        }

        int count = 0;
        vowelsFromStringASCII.Reverse();
        for (int j = 0; j < s.Length; j++)
        {
            if (IsVowel(s[j]))
            {
                result += (char)vowelsFromStringASCII[count];
                count++;
            }
            else
            {
                result += s[j];
            }
        }

        bool IsVowel(char p)
        {
            return vowels.Contains(p);
        }
        
        return result;
    }
}