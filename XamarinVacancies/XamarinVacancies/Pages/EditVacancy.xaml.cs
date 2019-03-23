using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVacancies.Database;
using XamarinVacancies.Models;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditVacancy : ContentPage
    {
        public EditVacancy(Vacancy vacancy)
        {
            InitializeComponent();

            Vacancy = vacancy;

            VacancyName.Text = Vacancy.VacancyName;
            Company.Text = Vacancy.Company;
            Quantity.Text = Vacancy.Quantity.ToString();
            City.Text = Vacancy.City;
            Salary.Text = Vacancy.Salary.ToString();
            Description.Text = Vacancy.Description;
            ContractType.IsToggled = Vacancy.ContractType == "FT";
            Telephone.Text = Vacancy.Telephone;
            Email.Text = Vacancy.Email;
        }

        private Vacancy Vacancy { get; }

        private void SaveAction(object sender, EventArgs e)
        {
            Vacancy.VacancyName = VacancyName.Text;
            Vacancy.Quantity = int.Parse(Quantity.Text);
            Vacancy.Salary = double.Parse(Quantity.Text);
            Vacancy.Company = Company.Text;
            Vacancy.City = City.Text;
            Vacancy.Description = Description.Text;
            Vacancy.ContractType = ContractType.IsToggled ? "FT" : "Ctrt";
            Vacancy.Telephone = Telephone.Text;
            Vacancy.Email = Email.Text;


            var db = new DbAccess();
            db.UpdateVacancy(Vacancy);

            Application.Current.MainPage = new NavigationPage(new MyVacancies());
        }
    }
}