using System;
namespace list8
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många koder vill du skriva in?");
            int antalKoder = int.Parse(Console.ReadLine());
            Dictionary<string, string> koder = new Dictionary<string, string>();

            for (int i = 0; i < antalKoder; i++)
            {
                string[] rad = Console.ReadLine().Split();
                koder[rad[0]] = rad[1];
            }

            Console.WriteLine("Skriv in ditt hemliga meddelande");
            string hemligt = Console.ReadLine();

            Console.WriteLine("Här är ditt avkodade meddelande:");
            for (int i = 0; i < hemligt.Length; i++)
            {
                string nästaTecken = hemligt[i].ToString();

                while (koder.ContainsKey(nästaTecken))
                {
                    nästaTecken = koder[nästaTecken];
                }
                Console.Write(nästaTecken);
            }
            Console.WriteLine();

        }
    }
}