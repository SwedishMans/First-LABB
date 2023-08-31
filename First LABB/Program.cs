namespace First_LABB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Välkommen till hänga gubbe!");
            Console.WriteLine("Skriv en Bokstav nedan");
            
            string guess1 = Console.ReadLine();

            string[] guesses = new string[5];

            guesses[0] = guess1;
            
            string[] Bokstaver = new string[3];

            Bokstaver[0] = "b";
            Bokstaver[1] = "o";
            Bokstaver[2] = "k";

            //Array with all the letters

            if (guesses = Bokstaver[0])
            {
                Console.WriteLine("b");
            }
            else if (guesses = Bokstaver[1])
            {
                Console.WriteLine("o");
            }
           
            
        }
    }
}