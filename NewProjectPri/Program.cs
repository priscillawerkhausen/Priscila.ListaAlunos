using System;
using System.Globalization;
using System.Threading;
using System.Collections.Generic;
using System.Security;
using System.Linq;

namespace NewProjectPri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá " + Environment.UserName + "!");

            Console.Write("Data e hora atuais: ");
            DateTime dataHora = DateTime.Now;
            Console.WriteLine(dataHora);

            Console.WriteLine();
            Console.WriteLine(" --------LISTA DE INFORMAÇÕES DOS ALUNOS-------- ");
            Console.WriteLine();
            Console.WriteLine("Comece adicionando alunos a sua lista: ");

            var alunos = new List<Aluno>();

            Console.WriteLine();
            Console.Write("Deseja adicionar algum aluno? s/n: ");
            string respost2 = Console.ReadLine();

            if (respost2 == "n")
            {
                Console.WriteLine();
                Console.WriteLine("Nenhum aluno foi adicionado a sua lista " + Environment.UserName + "!");
            }


            while (respost2 == "s")
            {
                Console.WriteLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Curso: ");
                string curso = Console.ReadLine();
                Console.Write("Código de matrícula: ");
                string codigoMatricula = Console.ReadLine();
                Console.Write("O aluno(a) foi aprovado ou reprovado? a/r: ");
                string status = Console.ReadLine();

                var alu = new Aluno(nome, curso, codigoMatricula, status);
                alunos.Add(alu);

                Console.WriteLine();
                Console.Write("Deseja adicionar mais algum aluno? s/n: ");
                respost2 = Console.ReadLine();


                if (respost2 == "n")
                {
                    Console.WriteLine();
                    Console.WriteLine("------LISTA------");
                    foreach (Aluno aluno in alunos)
                    {
                        aluno.Descrever();
                    }

                    Console.WriteLine();
                    Console.Write("Você deseja remover algum aluno? s/n: ");
                    string respostRemove = Console.ReadLine();

                    if (respostRemove == "s")
                    {
                        Console.WriteLine();
                        Console.Write("Digite o código de matrícula do aluno que você deseja remover: ");
                        codigoMatricula = Console.ReadLine();

                        var pesquisaCodigo = alunos.Where(listaAluno => listaAluno.CodigoMatricula == codigoMatricula).FirstOrDefault();
                        var codigoNaoEncontrado = pesquisaCodigo == null;

                        if (codigoNaoEncontrado)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Desculpe " + Environment.UserName + ", este código é inexistente! ");
                        }
                        else
                        {
                            alunos.Remove(pesquisaCodigo);
                            Console.WriteLine();
                            Console.WriteLine("O aluno foi removido! ");
                        }

                    }

                    Console.WriteLine();
                    Console.WriteLine("---------LISTA ATUALIZADA----------");
                    foreach (Aluno aluno1 in alunos)
                    {
                        aluno1.Descrever();
                    }

                }
            }



        }
    }
}







