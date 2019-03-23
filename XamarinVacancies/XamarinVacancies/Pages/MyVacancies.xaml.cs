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
    public partial class MyVacancies : ContentPage
    {
        public MyVacancies()
        {
            InitializeComponent();
            DbCon = new DbAccess();
            Refresh();
        }

        private IList<Vacancy> List { get; set; }
        private DbAccess DbCon { get; }

        private void EditVacancy(object sender, EventArgs e)
        {
            var lblEdit = (Label) sender;
            var vacancy = (Vacancy) ((TapGestureRecognizer) lblEdit.GestureRecognizers[0]).CommandParameter;
            Navigation.PushAsync(new EditVacancy(vacancy));
        }

        private void RemoveVacancy(object sender, EventArgs e)
        {
            var lblRemove = (Label) sender;
            var vacancy = (Vacancy) ((TapGestureRecognizer) lblRemove.GestureRecognizers[0]).CommandParameter;
            DbCon.RemoveVacancy(vacancy);
            Refresh();
        }

        private void Refresh()
        {
            List = DbCon.GetVacancies();
            VacancyList.ItemsSource = List;
            LblCount.Text = List.Count.ToString();
        }

        private void SearchVacancies(object sender, TextChangedEventArgs e)
        {
            VacancyList.ItemsSource = List.Where(a => a.VacancyName.Contains(e.NewTextValue)).ToList();
        }
    }
}