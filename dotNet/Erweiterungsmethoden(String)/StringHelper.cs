using System.Runtime.CompilerServices;

namespace Erweiterungsmethoden_String_
{
    public static class StringHelper
    {
        public static int ToInt32(this string str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                throw new Exception("Hilfe");
            }
        }

        public static string ReverseString(this string str)
        {
            string reversed = "";

            for(int i = str.Length-1; i >= 0; i--)
            {
                reversed = reversed + str[i];
            }
            return reversed;
        }

        public static bool IsPalindrome(this string str)
        {
            str.ToArray();
            string strrev = str.ReverseString();
            if(str == strrev)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }


    }
}
