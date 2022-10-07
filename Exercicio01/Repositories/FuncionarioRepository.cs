using Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Repositories
{
    public class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            #region Definindo o local do arquivo

                var path = $"c:\\temp\\funcionarios.txt";

            #endregion

            #region Gravando o arquivo em TXT

                using (var streamWriter = new StreamWriter(path, true))
                {
                    streamWriter.WriteLine($"ID..............: {funcionario.IdFuncionario}");
                    streamWriter.WriteLine($"NOME............: {funcionario.Nome}");
                    streamWriter.WriteLine($"CPF.............: {funcionario.Cpf}");
                    streamWriter.WriteLine($"DATA ADMISSÃO...: {funcionario.DataAdmissao}");
                    streamWriter.WriteLine($"MATRICULA.......: {funcionario.Matricula}");
                    streamWriter.WriteLine("\n");
            }

            #endregion


        }    
    }
}
