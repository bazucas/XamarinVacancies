using Xamarin.Forms;
using XamarinVacancies.Database;
using XamarinVacancies.Droid.Database;

[assembly:Dependency(typeof(Path))]
namespace XamarinVacancies.Droid.Database
{
    public class Path: IPath
    {
        public string GetPath(string databaseFileName)
        {
            var folderPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var dbPath = System.IO.Path.Combine(folderPath, databaseFileName);
            return dbPath;
        }
    }
}