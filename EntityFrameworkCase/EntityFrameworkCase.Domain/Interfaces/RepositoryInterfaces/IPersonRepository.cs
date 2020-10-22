using EntityFrameworkCase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces
{
    public interface IPersonRepository : IRepositoryBase<Person>
    {
    }
}
