﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LSG.GenericCrud.Exceptions;
using LSG.GenericCrud.Models;
using LSG.GenericCrud.Repositories;

namespace LSG.GenericCrud.Services
{
    public class CrudService<T> : ICrudService<T>
    {
        private readonly ICrudRepository<T> _repository;

        public CrudService(ICrudRepository<T> repository)
        {
            _repository = repository;
            AutoCommit = true;
        }

        public bool AutoCommit { get; set; }

        public IEnumerable<T> GetAll() => _repository.GetAll();

        public async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();

        public T GetById(Guid id)
        {
            var entity = _repository.GetById(id);
            if (entity == null) throw new EntityNotFoundException();
            return entity;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) throw new EntityNotFoundException();
            return entity;
        }

        public T Create(T entity)
        {
            var createdEntity = _repository.Create(entity);
            if (AutoCommit) _repository.SaveChanges();
            return createdEntity;
        }

        public async Task<T> CreateAsync(T entity)
        {
            var createdEntity = await _repository.CreateAsync(entity);
            if (AutoCommit) _repository.SaveChanges();
            return createdEntity;
        }

        public T Update(Guid id, T entity)
        {
            var originalEntity = GetById(id);
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (prop.Name != "Id")
                {
                    var originalProperty = originalEntity.GetType().GetProperty(prop.Name);
                    var value = prop.GetValue(entity, null);
                    if (value != null) originalProperty.SetValue(originalEntity, value);
                }
            }
            if (AutoCommit) _repository.SaveChanges();
            return originalEntity;
        }


        public async Task<T> UpdateAsync(Guid id, T entity)
        {
            var originalEntity = await GetByIdAsync(id);
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (prop.Name != "Id")
                {
                    var originalProperty = originalEntity.GetType().GetProperty(prop.Name);
                    var value = prop.GetValue(entity, null);
                    if (value != null) originalProperty.SetValue(originalEntity, value);
                }
            }
            if (AutoCommit) _repository.SaveChanges();
            return originalEntity;
        }

        public T Delete(Guid id)
        {
            var entity = GetById(id);
            _repository.Delete(id);
            if (AutoCommit) _repository.SaveChanges();
            return entity;
        }
        
        public async Task<T> DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            await _repository.DeleteAsync(id);
            if (AutoCommit) _repository.SaveChanges();
            return entity;
        }
    }
}