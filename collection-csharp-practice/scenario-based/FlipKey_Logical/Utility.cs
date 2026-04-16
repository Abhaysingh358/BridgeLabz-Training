using System.Text;
using System.Text.RegularExpressions;
namespace FlipKey_Logical
{
    public class Utility{
    public string CleanseAndInvert(string input)
    {
        if(string.IsNullOrEmpty(input) || (input.Length < 6))
        {
            return "";
        }

        string pattern = "^[a-zA-Z]+$";
        
        Match match = Regex.Match(input ,pattern);

        StringBuilder keysb = new StringBuilder();
        if (match.Success)
        {
            input = input.ToLower();
            for(int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                int ascii = (int)ch;
                if(ascii % 2 != 0)
                {
                    keysb.Append(ch);
                }
            }

            string key = keysb.ToString();
            string revkey = ReverseString(key);
            return EvenUpperCase(revkey);



        }
        else
        {
            return "";
        }



    }

    public  string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "";
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    

    public string EvenUpperCase(string input)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < input.Length; i++)
            {
                
                if (i % 2 == 0)
                {
                    sb.Append(Char.ToUpper(input[i]));
                }
                else
                {
                    sb.Append(input[i]);
                }
            }

            string EvenUpper = sb.ToString();
            return EvenUpper;
        }
    }
}