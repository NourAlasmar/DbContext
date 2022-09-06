using System.ComponentModel.DataAnnotations;


namespace NourApi.Model
{
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Company? Company { get; set; }
        public int? CompanyId { get; set; }


    }

}
