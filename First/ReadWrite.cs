using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace First
{
    public class ReadWrite
    {
        Rep rep = new Rep();
        string filepath = @"C:\Users\Andrej Vezovik\source\repos\KinopoiskMinamal\1.txt";
        public void writered(Film film)
        {
            rep.Methodick(film);
            FileStream fileStream = null;
            string text = "Film name: "+film.Name + ", Name 0f category: " + film.Category+
                ", Actors names: " + film.Actrors + ", Directors names: " + film.Director + ", Age of film:" + film.Age;
            if (!File.Exists(filepath))
                fileStream = File.Create(filepath);
            else fileStream = File.Open(filepath, FileMode.Append);
            StreamWriter output = new StreamWriter(fileStream);
            output.WriteLine(text);
            output.Close();
        }
       public void readered()
        {
            using (StreamReader sr = new StreamReader(filepath, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}

