namespace Hemuppgift_Loopar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SumInts();
            //MultiplicationTable();
            ListCount();
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

        //        Skriv ett C#-program som ber anv¨andaren att ange ett heltal och skriver ut
        //multiplikationstabellen f¨or det talet.

        static void MultiplicationTable()
        {
            Console.WriteLine("Ange ett heltal för att skriva ut multiplikationstabellen");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }

        //        Skriv ett program som skapar en lista med 
        //            siffror och r¨aknar hur m˚anga g˚anger
        //ett specifikt tal f¨orekommer i listan.

        static void ListCount()
        {
            //skapa en lista med siffror

            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 3, 4, 3, 4, 2, 4, 5, 6, 7, };
            int count = 0;
            int target = 3;

            foreach (int nbr in list)
            {
                if (nbr == target)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }


    }
}
