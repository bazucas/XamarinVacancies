using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinVacancies.Models;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VacancyDetails : ContentPage
    {
        public VacancyDetails(Vacancy vacancy)
        {
            InitializeComponent();

            DisplayAlert("Message", vacancy.VacancyName, "Ok");
        }
    }
}