using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Domain.DataTransferObjects
{
    public class PersonDto
    {
        public int Id { get; set; }
        public FirstNameDto FirstName { get; set; }
        public FirstNameDto SecondName { get; set; }
        public SurnameDto Surname { get; set; }
        public SurnameDto MotherSurname { get; set; }
        public CityDto BirthCity { get; set; }
        public WorkplaceDto Workplace { get; set; }
    }
}
