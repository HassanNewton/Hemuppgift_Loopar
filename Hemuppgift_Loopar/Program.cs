namespace Hemuppgift_Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumInts();
        }

        //Skriv ett C#-program som l¨aser in heltal och summerar dem. 
        //    Anta att inmatningen avslutas med talet 0.

        static void SumInts()
        {
            int sum = 0;
            int number;

            Console.WriteLine("Ange ett heltal för att summera, avsluta inmatning med 0");

            do
            {
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            while (number != 0);


            Console.WriteLine("summan av talen blir " + sum);
        }
    }
}
