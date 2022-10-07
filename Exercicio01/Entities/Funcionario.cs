﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Entities
{
    public class Funcionario
    {
        #region Propriedades

        public Guid IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataAdmissao { get; set; }
        public string Matricula { get; set; }

        #endregion
    }
}
