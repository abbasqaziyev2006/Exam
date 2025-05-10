﻿using AutoMapper;
using ExamSystem.Application.AutoMapping;
using ExamSystem.Application.Interfaces;
using ExamSystem.Domain.Entities;
using ExamSystem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExamSystem.Application.Services
{
    public class CrudManager<TEntity, TDto, TCreateDto, TUpdateDto> : ICrudService<TEntity, TDto, TCreateDto, TUpdateDto>
where TEntity : Entity
    {
        protected readonly ICrudRepository<TEntity> Repository;
        protected readonly IMapper Mapper;
        private ITeacherRepository teacherRepository;

        public CrudManager(IQuestionRepository questionRepository, IMapper mapper)
        {
            Repository = new EfCoreRepository<TEntity>();

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();

            });

            Mapper = config.CreateMapper();
            Mapper = mapper;
        }

        public CrudManager(IStudentRepository studentRepository, IMapper mapper)
        {
            Mapper = mapper;
        }

        public CrudManager(ITeacherRepository teacherRepository, IMapper mapper)
        {
            this.teacherRepository = teacherRepository;
            Mapper = mapper;
        }

        public virtual TDto Add(TCreateDto createDto)
        {
            var entity = Mapper.Map<TEntity>(createDto);
            var addedEntity = Repository.Add(entity);

            return Mapper.Map<TDto>(addedEntity);
        }

        public TDto Delete(int id)
        {
            var exist = Repository.GetById(id);

            if (exist == null)
                throw new InvalidOperationException("Entity not found");

            var deletedEntity = Repository.Delete(exist);

            return Mapper.Map<TDto>(deletedEntity);
        }

        public TDto Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            var entity = Repository.Get(predicate, asNoTracking, include);

            if (entity == null)
                throw new InvalidOperationException("Entity not found");

            return Mapper.Map<TDto>(entity);
        }

        public List<TDto> GetAll(Expression<Func<TEntity, bool>>? predicate = null, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var entities = Repository.GetAll(predicate, asNoTracking, include, orderBy);

            if (entities == null || !entities.Any())
                throw new InvalidOperationException("No entities found");

            return Mapper.Map<List<TDto>>(entities);
        }

        public TDto GetById(int id)
        {
            var entity = Repository.GetById(id);

            if (entity == null)
                throw new InvalidOperationException("Entity not found");

            return Mapper.Map<TDto>(entity);
        }

        public virtual TDto Update(TUpdateDto updateDto)
        {
            var updatedEntity = Mapper.Map<TEntity>(updateDto);

            var existingEntity = Repository.GetById(updatedEntity.Id);

            if (existingEntity == null)
                throw new InvalidOperationException("Entity not found");

            return Mapper.Map<TDto>(Repository.Update(updatedEntity));
        }
    }
    
}
