using Exercicio01.Entities;
using Exercicio01.Repositories;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n *** CADASTRO DE FUNCIONARIOS EM TXT *** \n");

            var funcionario = new Funcionario();

            funcionario.IdFuncionario = Guid.NewGuid();

            try
            {
                Console.Write("Informe o nome do funcionário.....: ");
                funcionario.Nome = Console.ReadLine();

                Console.Write("Informe o cpf do funcionario......: ");
                funcionario.Cpf = Console.ReadLine();

                Console.Write("Informe a data de admissão........: ");
                funcionario.DataAdmissao = DateTime.Parse(Console.ReadLine());

                Console.Write("Informe a matricula...............: ");
                funcionario.Matricula = Console.ReadLine();


                var funcionarioRepository = new FuncionarioRepository();

                funcionarioRepository.ExportarDados(funcionario);

                Console.WriteLine($"\nFuncionário {funcionario.Nome} cadastrado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nFalha ao cadastrar o funcionario!");
                Console.WriteLine($"Erro: {e.Message}");
            }
          
            Console.ReadKey();
        }
    }
}