﻿using LVSA.Farm.Application.Interfaces;
using LVSA.Farm.Application.ViewModels;
using LVSA.Farm.Domain;
using LVSA.Farm.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Farm.Application
{
    public class TipoMedicamentoAppService : AppServiceBase<TipoMedicamentoViewModel, TipoMedicamento, ITipoMedicamentoService>, ITipoMedicamentoAppService
    {
        public TipoMedicamentoAppService(ITipoMedicamentoService tipoMedicamentoService)
            : base(tipoMedicamentoService)
        {

        }

        public override IEnumerable<TipoMedicamentoViewModel> Todos()
        {
            return Filtrar(f => true);
        }
    }
}