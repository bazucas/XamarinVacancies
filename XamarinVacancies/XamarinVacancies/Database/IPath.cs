using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinVacancies.Database
{
    public interface IPath
    {
        string GetPath(string databaseFileName);
    } 
}
