using First;
using System;
using System.IO;


namespace KinopoiskMinamal
{
    class Program
    {
        static void Main(string[] args)
        {
            Film film = new Film();
           
            ReadWrite instanse1 = new ReadWrite();
            Console.WriteLine("Add Film use a,  or check List use c");
            string act = Console.ReadLine();
            switch (act)
            {
                case "a":
                    Console.WriteLine("Enter info");
                    instanse1.writered(film);
                   
                    break;
                case "c":
                    Console.WriteLine("all films");
                    instanse1.readered();
                    break;
                default:
                    Console.WriteLine("mimo, enter a or c");
                    break;
                    
            }
            
          
                Console.ReadKey();
        }          
    }
}
