using SQLite;

namespace XamarinVacancies.Models
{
    [Table("Vacancy")]
    public class Vacancy
    {
        [PrimaryKey] [AutoIncrement] public int Id { get; set; }

        public string VacancyName { get; set; }
        public int Quantity { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Description { get; set; }
        public string ContractType { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
    }
}