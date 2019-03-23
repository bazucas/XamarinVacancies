using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVacancies.Database;
using XamarinVacancies.Models;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddVacancies : ContentPage
    {
        public AddVacancies()
        {
            InitializeComponent();
        }

        private void SaveAction(object sender, EventArgs e)
        {
            var vac = new Vacancy
            {
                VacancyName = VacancyName.Text,
                Quantity = int.Parse(Quantity.Text),
                Salary = double.Parse(Quantity.Text),
                Company = Company.Text,
                City = City.Text,
                Description = Description.Text,
                ContractType = ContractType.IsToggled ? "FT" : "Ctrt",
                Telephone = Telephone.Text,
                Email = Email.Text
            };

            var db = new DbAccess();
            db.AddVacancy(vac);
            Application.Current.MainPage = new NavigationPage(new SearchVacancies());
        }
    }
}