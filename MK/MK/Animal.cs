using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MK
{
    public class Animal
    {
        public int Id { get; set; }
        public int AnimalTypeId { get; set; }
        public AnimalType AnimalTypes { get; set; }
    }
}
