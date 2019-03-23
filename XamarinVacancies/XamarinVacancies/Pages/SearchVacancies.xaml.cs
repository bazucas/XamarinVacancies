using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVacancies.Database;
using XamarinVacancies.Models;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchVacancies : ContentPage
    {
        public SearchVacancies()
        {
            InitializeComponent();

            var dbCon = new DbAccess();
            List = dbCon.GetVacancies();
            VacancyList.ItemsSource = List;
            LblCount.Text = List.Count.ToString();
        }

        private IList<Vacancy> List { get; }

        private void AddVacancy(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddVacancies());
        }

        private void MyVacancies(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyVacancies());
        }

        private void VacancyDetails(object sender, EventArgs e)
        {
            var lblDetail = (Label) sender;
            var vacancy = (Vacancy) ((TapGestureRecognizer) lblDetail.GestureRecognizers[0]).CommandParameter;
            Navigation.PushAsync(new VacancyDetails(vacancy));
        }

        private void SearchVacancy(object sender, TextChangedEventArgs e)
        {
            VacancyList.ItemsSource = List.Where(v => v.VacancyName.Contains(e.NewTextValue)).ToList();
        }
    }
}