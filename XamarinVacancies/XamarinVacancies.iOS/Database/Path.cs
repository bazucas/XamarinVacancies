using System;
using Xamarin.Forms;
using XamarinVacancies.Database;
using XamarinVacancies.iOS.Database;

[assembly: Dependency(typeof(Path))]

namespace XamarinVacancies.iOS.Database
{
    public class Path : IPath
    {
        public string GetPath(string databaseFileName)
        {
            var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var pathLibrary = System.IO.Path.Combine(folderPath, "..", "Library");
            var dbPath = System.IO.Path.Combine(pathLibrary, databaseFileName);
            return dbPath;
        }
    }
}