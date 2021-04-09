using System;
using System.Collections.Generic;

namespace escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola("ESACT");
            Curso ic = new Curso(1, "Informática e Comunicações");
            Curso mul = new Curso(2, "Multimédia");
            escola.adicionarCurso(ic);
            escola.adicionarCurso(mul);
            escola.listarCurso();

            ic.inserirAluno(1, "Redney Montyeiro", "Informatica e Comunicações", 1);
            ic.inserirAluno(2, "Livia Lopes", "Educação", 2);
            ic.listarAluno();
            ic.listarAlunoAno(2);
            ic.listarAlunoCurso("Educação");
            ic.pesquisarAluno(1);
            
            

        }
    }
    class Escola
    {
        string  designacao;
        
        List<Curso> listaCurso;
        public Escola(string designacao)
        {
            this.designacao = designacao;
            
            listaCurso = new List<Curso>();
        }
        public void inserirCurso(int numero, string designacao)
        {
            Curso curso = new Curso(numero, designacao);
            listaCurso.Add(curso);
        }
        public void adicionarCurso(Curso curso)
        {
            listaCurso.Add(curso);
        }
        public void listarCurso()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Lista dos Cursos");
            Console.WriteLine("------------------------------");
            foreach (Curso curso in listaCurso)
            {
                curso.monstrarCurso();
                Console.WriteLine("------------------------------");
            }
        }
    }
    class Curso
    {
        int numero;
        string designacao;
        List<Aluno> listaAluno;
        public Curso(int numero, string designacao)
        {
            this.numero = numero;
            this.designacao = designacao;
            listaAluno = new List<Aluno>();
        }
        public void monstrarCurso()
        {
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Designação: {designacao}");
        }
        public void inserirAluno(int numero, string nome, string curso, int ano)
        {
            Aluno a = new Aluno(numero, nome, curso, ano);
            listaAluno.Add(a);
        }
        public void listarAluno()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Lista dos Alunos");
            Console.WriteLine("------------------------------");
            foreach (Aluno aluno in listaAluno)
            {
                aluno.monstrarAluno();
                Console.WriteLine("------------------------------");
            }
        }
        public Aluno pesquisarAluno(int numero)
        {
            foreach (Aluno aluno in listaAluno)
            {
                if(numero == aluno.getNumero())
                {
                    Console.WriteLine("Encontrado");
                    return aluno;
                }
            }
            return null;
        }
        public void listarAlunoCurso(string curso)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Lista dos alunos de {curso}");
            Console.WriteLine("------------------------------");
            foreach (Aluno aluno in listaAluno)
            {
                if(curso == aluno.getCurso())
                {
                    aluno.monstrarAluno();
                    Console.WriteLine("------------------------------");
                }
            }
        }
        public void listarAlunoAno(int ano)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Lista dos Alunos do {ano}º ano");
            Console.WriteLine("------------------------------");
            foreach (Aluno aluno in listaAluno)
            {
                if (ano == aluno.getAno())
                {
                    aluno.monstrarAluno();
                    Console.WriteLine("------------------------------");
                }
            }
        }
    }
    class Aluno
    {
        int numero, ano;
        string nome, curso;
        public Aluno(int numero, string nome, string curso, int ano)
        {
            this.numero = numero;
            this.nome = nome;
            this.curso = curso;
            this.ano = ano;
        }
        public void monstrarAluno()
        {
            Console.WriteLine($"Número: {numero}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Ano: {ano}º ano");
        }
        public int getNumero()
        {
            return this.numero;
        }
        public string getCurso()
        {
            return this.curso;
        }
        public int getAno()
        {
            return this.ano;
        }
    }
}
