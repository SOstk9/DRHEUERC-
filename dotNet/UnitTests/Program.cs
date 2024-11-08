namespace UnitTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }


        public static string GroßBuchstabenKonvertierung(string satz)
        {
            satz = satz.ToLower();
            string resultSatz = "";
            char[] satzChar = satz.ToCharArray();
            for (int i = 0; i < satzChar.Length; i++)
            {
                if (satzChar[i] == ' ')
                {
                    satzChar[0] = char.ToUpper(satzChar[0]);
                    satzChar[i+1] = char.ToUpper(satzChar[i+1]);
                }
            }
            foreach (char ch in satzChar)
            {
                resultSatz += ch;
            }
            
            return resultSatz;

        }
    }
}
