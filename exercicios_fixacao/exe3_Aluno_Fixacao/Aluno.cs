using System;
using System.Globalization;

namespace Course;

class Aluno
{
    private string Nome;
    private double Nota1, Nota2, Nota3;

    public Aluno(string nome, double notaq, double nota2, double nota3)
    {
        this.Nome = nome;
        this.Nota1 = notaq;
        this.Nota2 = nota2;
        this.Nota3 = nota3;
    }

    public double NotaFinal()
    {
        return Nota1 + Nota2 + Nota3;
    }

    public double NotaRestante()
    {
        return 60.0 - NotaFinal();
    }

    public override string ToString()
    {
        return "\nNOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
    }
}
