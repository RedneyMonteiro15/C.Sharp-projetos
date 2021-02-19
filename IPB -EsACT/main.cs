using System.Collections.Generic;
using System;
class HelloWorld {
  static void Main() {
    Esact ipb = new Esact();
  }
}
class Esact{
    List<Docente> ListaDocente;
    List<Aluno> ListaAluno;
    
    public Esact(){
        ListaAluno = new List<Aluno>();
        ListaDocente = new List<Docente>();
    }
    public void InserirAluno(string nome, int numero, string curso, int ano){
        Aluno a1 = new Aluno(nome, numero, curso, ano);
        if(a1 == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao adicionar o aluno.");
            Console.ResetColor();
            return;
        }
        this.ListaAluno.Add(a1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Aluno adicionado com sucesso.");
        Console.ResetColor();
    }
    public void InserirDocente(string nome, int numero, string departamento, string habilidades){
        Docente d1 = new Docente(nome, numero, departamento, habilidades);
        if(d1 == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro ao adicionar docente.");
            Console.ResetColor();
            return;
        }
        this.ListaDocente.Add(d1);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Docente adiconado com sucesso.");
        Console.ResetColor();
    }
    public void ListarAluno(){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nLista dos Alunos");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        foreach(Aluno a in ListaAluno){
            a.MonstrarA();
            Console.WriteLine("--------------------");
        }
    }
    public void ListarDocente(){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nLista dos Docentes");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        foreach(Docente d in ListaDocente){
            d.MonstrarD();
            Console.WriteLine("--------------------");
        }
    }
    public void MonstrarAluno(int numero){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nMonstrar Aluno:");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        foreach(Aluno a in ListaAluno){
            if(numero == a.GetNumero()){
                a.MonstrarA();
                Console.WriteLine("--------------------");
            }
        }
    }
    public void MonstrarDocente(int numero){
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nMonstrar Docente:");
        Console.ResetColor();
        Console.WriteLine("--------------------");
        foreach(Docente d in ListaDocente){
            if(numero == d.GetNum()){
                d.MonstrarD();
                Console.WriteLine("--------------------");
            }
        }
    }
    
    public Aluno PesquisarAluno(int numero){
        foreach(Aluno a in ListaAluno){
            if(numero == a.GetNumero()){
                return a;
            }
        }
        return null;
    }
    public void RemoverAluno(int numero){
        Aluno a = this.PesquisarAluno(numero);
        if(a == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não foi possível eliminar o aluno.");
            Console.ResetColor();
            return;
        }
        this.ListaAluno.Remove(a);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro aluno eliminado com sucesso.");
        Console.ResetColor();
        }
    public Docente PesquisarDocente(int numero){
        foreach(Docente d in ListaDocente){
            if(numero == d.GetNum()){
                return d;
            }
        }
        return null;
    }
    public void RemoverDocente(int numero){
        Docente d = this.PesquisarDocente(numero);
        if(d == null){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não foi possível eliminadar o docente.");
            Console.ResetColor();
            return;
        }
        this.ListaDocente.Remove(d);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro docente eliminado com sucesso.");
        Console.ResetColor();
    }
}
class Docente{
    string nome, departamento, habilidades;
    int numero;
    public Docente(string nome, int numero, string departamento, string habilidades){
        this.nome = nome;
        this.numero = numero;
        this.departamento = departamento;
        this.habilidades = habilidades;
    }
    public void MonstrarD(){
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Número: " + numero);
        Console.WriteLine("Departamento: " + departamento);
        Console.WriteLine("Habilidades: " + habilidades);
    }
    public int GetNum(){
        return this.numero;
    }
}
class Aluno{
    string nome, curso;
    int numero, ano;
    public Aluno(string nome, int numero, string curso, int ano){
        this.nome = nome;
        this.numero = numero;
        this.curso = curso;
        this.ano = ano;
    }
    public void MonstrarA(){
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("Número: " + this.numero);
        Console.WriteLine("Curso: " + this.curso);
        Console.WriteLine("Ano: " + this.ano);
    }
    public int GetNumero(){
        return this.numero;
    }
}