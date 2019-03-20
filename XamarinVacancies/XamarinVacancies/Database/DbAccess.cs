using System.Collections.Generic;
using SQLite;
using XamarinVacancies.Models;
using Xamarin.Forms;

namespace XamarinVacancies.Database
{
    public class DbAccess
    {
        private readonly SQLiteConnection _con;

        public DbAccess()
        {
            var dep = DependencyService.Get<IPath>();
            var path = dep.GetPath("database.sqlite");
            _con = new SQLiteConnection(path);
            _con.CreateTable<Vacancy>();
        }

        public void AddVacancy(Vacancy vacancy)
        {
            _con.Insert(vacancy);
        }

        public void RemoveVacancy(Vacancy vacancy)
        {
            _con.Delete(vacancy);
        }

        public void UpdateVacancy(Vacancy vacancy)
        {
            _con.Update(vacancy);
        }

        public IEnumerable<Vacancy> SearchVacancies(string word)
        {
            return _con.Table<Vacancy>().Where(v => v.VacancyName.Contains(word)).ToList();
        }

        public IEnumerable<Vacancy> GetVacancies()
        {
            return _con.Table<Vacancy>().ToList();
        }

        public Vacancy GetVacancyById(int id)
        {
            return _con.Table<Vacancy>().FirstOrDefault(v => v.Id == id);
        }
    }
}
