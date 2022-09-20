using Application.Models;
using Application.Repository;
using Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PersonalloanServices
    {

        private int calc_monthly_fee = 0;
        private int calc_interest_rate = 0;

        public void CalculatePersonalloans(PersonalloansModel data)
        {
            if(data.personalloansType == (int)PersonalloansEnums.PersonalloansTypes.PERSONAL)
            {
                calc_interest_rate = (((data.personalloansType * data.amount) / 100) + data.amount);
                calc_monthly_fee = (calc_interest_rate / data.personalloansTypeBase);

                PersonalloansRepository.Instance.PersonalloansModel.interestRate = calc_interest_rate;
                PersonalloansRepository.Instance.PersonalloansModel.results = calc_monthly_fee;
            } else
            {
                if (data.personalloansType == (int)PersonalloansEnums.PersonalloansTypes.AUTOMOVIL)
                {
                    calc_interest_rate = (((data.personalloansType * data.amount) / 100) + data.amount);
                    calc_monthly_fee = (calc_interest_rate / data.personalloansTypeBase);

                    PersonalloansRepository.Instance.PersonalloansModel.interestRate = calc_interest_rate;
                    PersonalloansRepository.Instance.PersonalloansModel.results = calc_monthly_fee;
                } else
                {
                    if (data.personalloansType == (int)PersonalloansEnums.PersonalloansTypes.MORTGAGE)
                    {
                        calc_interest_rate = (((data.personalloansType * data.amount) / 100) + data.amount);
                        calc_monthly_fee = (calc_interest_rate / data.personalloansTypeBase);

                        PersonalloansRepository.Instance.PersonalloansModel.interestRate = calc_interest_rate;
                        PersonalloansRepository.Instance.PersonalloansModel.results = calc_monthly_fee;
                    }
                }
            }
        }

        public PersonalloansModel getPersonalloansResults()
        {
            return PersonalloansRepository.Instance.PersonalloansModel;
        }
    }
}
