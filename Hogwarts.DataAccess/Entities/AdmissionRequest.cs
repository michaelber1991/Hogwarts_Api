using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.DataAccess.Entities
{
    public class AdmissionRequest
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public short Age { get; set; }
        public Guid HouseId { get; set; }
        public virtual House House { get; set; }
    }
}
