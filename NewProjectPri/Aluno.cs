using System;
using System.Collections.Generic;
using System.Text;
using System.Security;

namespace NewProjectPri
{
    class Aluno
    {
        public string Nome { get; private set; }
        public string Curso { get; private set; }
        public string CodigoMatricula { get; private set; }
        public string Status { get; private set; }

        public Aluno(string nome, string curso, string codigoMatricula, string status)
        {
            Nome = nome;
            Curso = curso;
            CodigoMatricula = codigoMatricula;
            Status = status;
        }
        public void Descrever()
        {
            Console.WriteLine();
            Console.WriteLine($"Nome----------------: {Nome}");
            Console.WriteLine($"Curso---------: {Curso}");
            Console.WriteLine($"Código da matrícula-------: {CodigoMatricula}");
            Console.WriteLine($"Status----------: {Status}");
        }
    }
}
