﻿using LSG.GenericCrud.Controllers;
using LSG.GenericCrud.Dto.Services;
using Microsoft.AspNetCore.Mvc;
using Sample.Complete.Models.DTOs;
using Sample.Complete.Models.Entities;

namespace Sample.Complete.Controllers
{
    [Route("api/[controller]")]
    public class AccountsDtoController : CrudController<AccountDto>
    {
        public AccountsDtoController(CrudService<AccountDto, Account> service) : base(service) { }
    }
}
