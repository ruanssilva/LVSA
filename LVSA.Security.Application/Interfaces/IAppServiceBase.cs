﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LVSA.Security.Application.Models;

namespace LVSA.Security.Application.Interfaces
{
    public interface IAppServiceBase<TViewModel, TEntity> : LVSA.Base.Application.Interfaces.IAppServiceBase<TViewModel, TEntity>
        where TViewModel : class
        where TEntity : class
    {
        void SetSeguranca(Seguranca seguranca, bool filter = true);
    }
}
