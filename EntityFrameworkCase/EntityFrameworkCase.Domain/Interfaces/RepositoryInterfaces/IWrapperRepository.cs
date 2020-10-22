using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces
{
    public interface IWrapperRepository
    {
        IPersonRepository Person { get; }

        void Save();
    }
}
