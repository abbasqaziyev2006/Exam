using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query;

namespace ExamSystem.Application.Interfaces
{
    public interface ICrudService<TEntity, TDto, TCreateDto, TUpdateDto>
    {
        TDto GetById(int id);

        TDto Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null);

        List<TDto> GetAll(Expression<Func<TEntity, bool>>? predicate = null, bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null);

        TDto Add(TCreateDto createDto);

        TDto Update(TUpdateDto updateDto);

        TDto Delete(int id);
    }
}
