﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LVSA.Base.Domain.Services;
using LVSA.Security.Domain.Interfaces.Repository;
using LVSA.Security.Domain.Interfaces.Services;

namespace LVSA.Security.Domain.Services
{
    public class ColigadaService : ServiceBase<Coligada>, IColigadaService
    {

        public ColigadaService(IColigadaRepository coligadaRepository)
            : base(coligadaRepository)
        {
        }

        

    }
}
