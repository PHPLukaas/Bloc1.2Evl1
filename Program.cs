/** 
 * Exercice 22
 * Author: Lukas
 * date : 21/10/2021
 */
using System;
namespace Ex_22
{
    class Program
    {
        static void Main(string[] args)
        {
            float note = 0;
            int dessus = 0; 
            int dessous = 0;
            Console.WriteLine("Veuillez tapez dix notes.");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("> " + i + " note");
                bool correct = false;
                while (!correct)
                {
                    try 
                    {
                        note = float.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Veuillez taper un nombre valide");
                    }
                }
                if (note < 10)
                {
                    dessous++;
                }
                else if (note >= 10)
                {
                    dessus++;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Il y a " + dessus + " notes en dessus de la moyenne");
            Console.WriteLine("Et " + dessous + " notes en dessous de la moyenne");
        }
    }
}