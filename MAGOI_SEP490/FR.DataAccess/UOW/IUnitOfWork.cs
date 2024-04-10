﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveAsync();
    }
}