using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVacancies.Models;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchVacancies : ContentPage
    {
        public SearchVacancies()
        {
            InitializeComponent();
        }

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
            var vacancy = (Vacancy)((TapGestureRecognizer)lblDetail.GestureRecognizers[0]).CommandParameter;
            Navigation.PushAsync(new VacancyDetails(vacancy));
        }
    }
}