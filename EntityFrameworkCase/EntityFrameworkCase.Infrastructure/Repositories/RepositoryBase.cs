﻿using EntityFrameworkCase.Domain.Interfaces.RepositoryInterfaces;
using EntityFrameworkCase.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EntityFrameworkCase.Infrastructure.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public void Create(T entity)
        {
            RepositoryContext.ChangeTracker.TrackGraph(entity, e =>
            {
                if (e.Entry.IsKeySet)
                {
                    e.Entry.State = EntityState.Unchanged;
                }
                else
                {
                    e.Entry.State = EntityState.Added;
                }
            });

            //this.RepositoryContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity); ;
        }

        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
        }

        //private void CheckIsTracking(EntityEntryGraphNode e)
        //{
        //    var entries = RepositoryContext.ChangeTracker.Entries().Select(s => new  { Name = s.Entity.GetType().Name, Id = s.Entity.GetType().GetProperty("Id").GetValue(s.Entity) }).ToList();

        //    var entry = new { Name = e.Entry.Entity.GetType().Name, Id = e.Entry.Entity.GetType().GetProperty("Id").GetValue(e.Entry.Entity) };

        //    if (!entries.Contains(entry))
        //    {
        //        if (e.Entry.IsKeySet)
        //        {
        //            e.Entry.State = EntityState.Unchanged;
        //        }
        //        else
        //        {
        //            e.Entry.State = EntityState.Added;
        //        }
        //    }
        //}
    }
}
