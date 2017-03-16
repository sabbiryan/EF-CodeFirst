using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Company : Entity
    {
        [Required]
        public string Name { get; set; }

        public string Adddress { get; set; }

        public string Phone { get; set; }
    }
}
