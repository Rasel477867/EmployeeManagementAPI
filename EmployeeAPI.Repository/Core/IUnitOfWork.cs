﻿using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository.Core
{
    public interface IUnitOfWork
    {
        Task<bool> CompleteAsync();
      
    }
}
