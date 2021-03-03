using System;
using System.Collections.Generic;
using System.Text;

namespace First
{
    public interface IFilm: IDisposable
    {
        IEnumerable<Film> GetFilmsList();
        Film GetFilms(int id);

        void Create(Film item);
        void Update(Film item);
        void Delete(int id);
        void Save();
    }
}
