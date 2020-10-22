using EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces;
using EntityFrameworkCase.Domain.Models;
using EntityFrameworkCase.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Infrastructure.Repositories
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {

        }
    }
}
