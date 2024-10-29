namespace DelegatesGroßKlein
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe = "hallo";

            CharacterHandler ch = Character.UpperLower;
            ch = Character.LowerCase;
            ch = Character.UpperCase;

            ch(eingabe);

            //Multi
            CharacterHandler chm = ch += Character.LowerCase;
            ch(eingabe);
            

            //


            Console.ReadLine();
        }
    }
}
