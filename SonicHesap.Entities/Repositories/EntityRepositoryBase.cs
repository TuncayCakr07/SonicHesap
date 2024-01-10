﻿using FluentValidation;
using FluentValidation.TestHelper;
using SonicHesap.Entities.Interfaces;
using SonicHesap.Entities.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SonicHesap.Entities.Repositories
{
    public class EntityRepositoryBase<TContext, TEntity,TValidator> : IEntityRepository<TContext, TEntity>
    where TContext : DbContext, new()
    where TEntity : class, IEntity, new()
    where TValidator:IValidator,new()
    {

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().SingleOrDefault(filter);
        }

        public bool AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator=new TValidator();
            var validationResult = ValidatorTool.Validate(validator, entity);
            if (validationResult)
            {
              context.Set<TEntity>().AddOrUpdate(entity);
            }
            return validationResult;
            
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }
    }
}
