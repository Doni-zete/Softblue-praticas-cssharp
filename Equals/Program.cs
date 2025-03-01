﻿using System;


namespace Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "abc";

            Console.WriteLine(s1.Equals(s2));
            int i1 = 10;
            int i2 = 10;
            Console.WriteLine(i1.Equals(i2));

            Aluno a1 = new Aluno("Pedro");
            Aluno a2 = a1; //Aluno("Pedro");
            Console.WriteLine(a1.Equals(a2));

        }
    }
}
public class Aluno
{
    public string Nome { get; set; }
    public Aluno(string nome)
    {
        this.Nome = nome;
    }

    public override bool Equals(object obj)
    {
        Aluno aluno = obj as Aluno;
        if (aluno == null)
        {
            throw new ArgumentException("Objeto deve ser um Aluno");

        }

        return this.Nome.Equals(aluno.Nome);
    }

}


