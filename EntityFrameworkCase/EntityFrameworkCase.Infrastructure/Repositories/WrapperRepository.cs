using EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces;
using EntityFrameworkCase.Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Infrastructure.Repositories
{
    public class WrapperRepository : IWrapperRepository
    {
        public WrapperRepository(RepositoryContext context)
        {
            _context = context;
        }

        private RepositoryContext _context;

        private IPersonRepository _person;

        public IPersonRepository Person 
        { 
            get
            {
                if (_person == null)
                {
                    _person = new PersonRepository(_context);
                }

                return _person;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
