﻿using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LSG.GenericCrud.Exceptions;
using LSG.GenericCrud.Models;
using LSG.GenericCrud.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace LSG.GenericCrud.Dto.Controllers
{
    //public class CrudAsyncController<TDto, TEntity> :
    //  Controller
    //  where TDto : class, IEntity, new()
    //  where TEntity : class, IEntity, new()
    //{
    //    private readonly IMapper _mapper;
    //    private readonly Crud<TEntity> _dal;

    //    public CrudAsyncController(Crud<TEntity> dal, IMapper mapper)
    //    {
    //        _dal = dal;
    //        _mapper = mapper;
    //    }

    //    [HttpGet]
    //    public new async Task<IActionResult> GetAll()
    //    {
    //        var entities = await _dal.GetAllAsync();
    //        var dtos = entities.Select(_ => _mapper.Map<TDto>(_));
    //        return Ok(dtos);
    //    }

    //    [Route("{id}")]
    //    [HttpGet]
    //    public async Task<IActionResult> GetById(Guid id)
    //    {
    //        try
    //        {
    //            return Ok(_mapper.Map<TDto>(await _dal.GetByIdAsync(id)));
    //        }
    //        catch (EntityNotFoundException ex)
    //        {
    //            return NotFound();
    //        }
    //    }

    //    /// <summary>
    //    /// Creates the specified entity.
    //    /// </summary>
    //    /// <param name="entity">The entity.</param>
    //    [HttpPost("")]
    //    public async Task<IActionResult> Create([FromBody] TDto dto)
    //    {
    //        var entity = _mapper.Map<TEntity>(dto);
    //        var createdEntity = await _dal.CreateAsync(entity);
    //        return Ok(_mapper.Map<TDto>(createdEntity));
    //    }

    //    [HttpPut("{id}")]
    //    public async Task<IActionResult> Update(Guid id, [FromBody] TDto dto)
    //    {
    //        try
    //        {
    //            var entity = _mapper.Map<TEntity>(dto);
    //            await _dal.UpdateAsync(id, entity);
    //            return Ok();
    //        }
    //        catch (EntityNotFoundException ex)
    //        {
    //            return NotFound();
    //        }
    //    }

    //    [HttpDelete("{id}")]
    //    public async Task<IActionResult> Delete(Guid id)
    //    {
    //        try
    //        {
    //            await _dal.DeleteAsync(id);
    //            return Ok();
    //        }
    //        catch (EntityNotFoundException ex)
    //        {
    //            return NotFound();
    //        }

    //    }

    //}
}
