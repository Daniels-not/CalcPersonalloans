using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Repository
{
    public class PersonalloansRepository
    {
        public static PersonalloansRepository Instance { get; } = new();
        public PersonalloansModel PersonalloansModel = new();

        private PersonalloansRepository()
        {

        }
    }
}
