using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace NourApi.Model
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public ICollection<Employee>? Employees { get; set; }


    }
}
