﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LVSA.Housing.Application.ViewModels
{
    public class MultaMoradorViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Morador")]
        public int MoradorId { get; set; }
        [Required]
        [Display(Name = "Multa")]
        public int MultaId { get; set; }
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Required]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }
        [Display(Name = "Valor desconto")]
        public decimal Desconto { get; set; }
        [Display(Name = "Valor jurus")]
        public decimal Juros { get; set; }
        [Required]
        [Display(Name = "Data referente")]
        public DateTime DataReferencia { get; set; }
        [Required]
        [Display(Name = "Data de vencimento")]
        public DateTime? DataVencimento { get; set; }
        [Required]
        [Display(Name = "Data de pagamento")]
        public DateTime? DataPagamento { get; set; }
        public virtual MoradorViewModel Morador { get; set; }
        public virtual MultaViewModel Multa { get; set; }
    }
}