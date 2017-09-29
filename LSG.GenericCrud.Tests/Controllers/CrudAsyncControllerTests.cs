﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;
using LSG.GenericCrud.Controllers;
using LSG.GenericCrud.Exceptions;
using LSG.GenericCrud.Repositories;
using LSG.GenericCrud.Tests.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace LSG.GenericCrud.Tests.Controllers
{
    
    public class CrudAsyncControllerTests
    {
        private readonly IList<TestEntity> _entities;
        private readonly TestEntity _entity;

        public CrudAsyncControllerTests()
        {
            Randomizer.Seed = new Random(1234567);
            var entityFaker = new Faker<TestEntity>().
                RuleFor(_ => _.Id, Guid.NewGuid()).
                RuleFor(_ => _.Value, _ => _.Lorem.Word());
            _entities = entityFaker.Generate(5);
            _entity = entityFaker.Generate();
        }

        //[Fact]
        //public async Task GetAll_ReturnsOk()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    dalMock.Setup(_ => _.GetAll()).Returns(_entities);
        //    var controller = new CrudAsyncController<TestEntity>(dalMock.Object);

        //    var actionResult = await controller.GetAll();
        //    var okResult = actionResult as OkObjectResult;
        //    var model = okResult.Value as IEnumerable<TestEntity>;

        //    Assert.Equal(model.Count(), _entities.Count);
        //    dalMock.Verify(_ => _.GetAll(), Times.Once);
        //}

        //[Fact]
        //public void GetById_ReturnsOk()
        //{
        //    var id = _entities[0].Id;
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    dalMock.Setup(_ => _.GetById(id)).Returns(_entities[0]);
        //    var controller = new CrudController<TestEntity>(dalMock.Object);
            
        //    var actionResult = controller.GetById(id);
        //    var okResult = actionResult as OkObjectResult;
        //    var model = okResult.Value as TestEntity;

        //    Assert.Equal(model.Id, id);
        //    dalMock.Verify(_ => _.GetById(It.IsAny<Guid>()), Times.Once);
        //}

        //[Fact]
        //public void GetById_ReturnsNotFound()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    dalMock.Setup(_ => _.GetById(It.IsAny<Guid>())).Throws(new EntityNotFoundException());
        //    var controller = new CrudController<TestEntity>(dalMock.Object);
            
        //    var actionResult = controller.GetById(Guid.NewGuid());
            
        //    Assert.IsType(typeof(NotFoundResult), actionResult);
        //    dalMock.Verify(_ => _.GetById(It.IsAny<Guid>()), Times.Once);
        //}

        //[Fact]
        //public void Create_ReturnsCreatedEntity()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    var controller = new CrudController<TestEntity>(dalMock.Object);

        //    var actionResult = controller.Create(_entity);

        //    Assert.IsType<OkObjectResult>(actionResult);
        //    dalMock.Verify(_ => _.Create(It.IsAny<TestEntity>()), Times.Once);
        //}

        //[Fact]
        //public void Update_ReturnsModifiedEntity()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    var controller = new CrudController<TestEntity>(dalMock.Object);

        //    var actionResult = controller.Update(_entity.Id, _entity);

        //    Assert.IsType<OkResult>(actionResult);
        //    dalMock.Verify(_ => _.Update(It.IsAny<Guid>(), It.IsAny<TestEntity>()), Times.Once);
        //}

        //[Fact]
        //public void Update_ReturnsNotFound()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    dalMock.Setup(_ => _.Update(It.IsAny<Guid>(), It.IsAny<TestEntity>())).Throws<EntityNotFoundException>();
        //    var controller = new CrudController<TestEntity>(dalMock.Object);

        //    var actionResult = controller.Update(_entity.Id, _entity);

        //    Assert.IsType(typeof(NotFoundResult), actionResult);
        //    dalMock.Verify(_ => _.Update(It.IsAny<Guid>(), It.IsAny<TestEntity>()), Times.Once);
        //}

        //[Fact]
        //public void Delete_ReturnsOk()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    var controller = new CrudController<TestEntity>(dalMock.Object);

        //    var actionResult = controller.Delete(_entity.Id);

        //    Assert.IsType(typeof(OkResult), actionResult);
        //    dalMock.Verify(_ => _.Delete(It.IsAny<Guid>()), Times.Once);
        //}

        //[Fact]
        //public void Delete_ReturnsNotFound()
        //{
        //    var dalMock = new Mock<Crud<TestEntity>>();
        //    dalMock.Setup(_ => _.Delete(It.IsAny<Guid>())).Throws<EntityNotFoundException>();
        //    var controller = new CrudController<TestEntity>(dalMock.Object);

        //    var actionResult = controller.Delete(_entity.Id);

        //    Assert.IsType(typeof(NotFoundResult), actionResult);
        //    dalMock.Verify(_ => _.Delete(It.IsAny<Guid>()), Times.Once);
        //}
    }
}
