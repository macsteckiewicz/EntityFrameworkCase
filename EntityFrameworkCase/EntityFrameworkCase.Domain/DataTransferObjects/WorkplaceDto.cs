using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Domain.DataTransferObjects
{
    public class WorkplaceDto
    {
        public int Id { get; set; }
        public CityDto City { get; set; }
        public StreetDto Street { get; set; }
    }
}
