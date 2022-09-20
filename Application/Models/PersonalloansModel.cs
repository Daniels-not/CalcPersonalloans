using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class PersonalloansModel
    {
        public int amount { get; set; } = 0;
        public int personalloansType { get; set; }
        public int personalloansTypeBase { get; set; }
        public int interestRate { get; set; } = 0;
        public int results { get; set; } = 0;
    }
}
