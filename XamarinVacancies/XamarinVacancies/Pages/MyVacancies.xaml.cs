using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinVacancies.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyVacancies : ContentPage
    {
        public MyVacancies()
        {
            InitializeComponent();
        }

        private void EditVacancy(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RemoveVacancy(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}