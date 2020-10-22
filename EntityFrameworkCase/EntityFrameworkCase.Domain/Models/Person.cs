using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkCase.Domain.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FirstNameId { get; set; }
        public virtual FirstName FirstName { get; set; }

        public int SecondNameId { get; set; }
        public virtual FirstName SecondName { get; set; }

        public int SurnameId { get; set; }
        public virtual Surname Surname { get; set; }

        public int MotherSurnameId { get; set; }
        public virtual Surname MotherSurname { get; set; }

        public int BirthCityId { get; set; }
        public virtual City BirthCity { get; set; }

        public int WorkplaceId { get; set; }
        public virtual Workplace Workplace { get; set; }
    }
}
