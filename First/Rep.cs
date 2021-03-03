using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace First
{
    public class Rep
    {
       
        public void Methodick(Film film)
        {
           
            Console.Write("Enter Name:  ");
            film.Name = Console.ReadLine();
            Console.WriteLine("Enter Category:  ");
            film.Category = Console.ReadLine();
            Console.WriteLine("Enter Actors:  ");
            film.Actrors = Console.ReadLine();
            Console.WriteLine("Enter Director:  ");
            film.Director = Console.ReadLine();
            Console.WriteLine("Enter Age:  ");
            film.Age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
