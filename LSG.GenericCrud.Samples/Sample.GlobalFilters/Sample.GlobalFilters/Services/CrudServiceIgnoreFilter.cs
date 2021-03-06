﻿using System.Collections.Generic;
using LSG.GenericCrud.Models;
using LSG.GenericCrud.Services;
using Sample.GlobalFilters.Controllers;
using Sample.GlobalFilters.Repositories;

namespace Sample.GlobalFilters.Services
{
    public class CrudServiceIgnoreFilter<T> : CrudService<T> where T : class, IEntity, new()
    {
        private readonly CrudRepositoryIgnoreFilter _repository;

        public CrudServiceIgnoreFilter(CrudRepositoryIgnoreFilter repository) : base(repository) => _repository = repository;

        public IEnumerable<T> GetAllIgnoreFilters()
        {
            return _repository.GetAllIgnoreFilter<T>();
        }

    }
}