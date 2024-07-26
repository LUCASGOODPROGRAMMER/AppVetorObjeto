using AppVetorObjetos.RegrasDeNegocio;

Aluno[] salaDeAula = new Aluno[3];
Aluno alunoIfro;

int contador = 1;
int posicao = 0;

while (posicao < 3)
{
    Console.Clear();
    Console.WriteLine("CADASTRO DO ALUNO [" +contador+ "]");
    Console.WriteLine();
    alunoIfro = new Aluno(); // criando novos alunos

    alunoIfro.Id = contador;
    alunoIfro.NumeroDeMatricula = contador * 1000;

    Console.Write("Nome....................!");
    alunoIfro.Nome = Console.ReadLine();

    Console.Write("Nota1....................!");
    alunoIfro.Nota1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Nota2....................!");
    alunoIfro.Nota2 = Convert.ToDouble(Console.ReadLine());

    salaDeAula[posicao] = alunoIfro;
    contador++; posicao++;
}

Console.Clear();
Console.WriteLine("@@@@@@@@@@@@@@@ LISTA DOS ALUNOS CADASTRADOS @@@@@@@@@@@@@@@");
Console.WriteLine();
Aluno alunoIfroDados = new Aluno();

for (int i = 0; i < salaDeAula.Length; i++)
{
    alunoIfroDados = salaDeAula[i];
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("Id.....................:" + alunoIfroDados.Id);
    Console.WriteLine("Matrícula.....................:" + alunoIfroDados.NumeroDeMatricula);
    Console.WriteLine("Nome.....................:" + alunoIfroDados.Nome);
    Console.WriteLine("Nota 1.....................:" + alunoIfroDados.Nota1);
    Console.WriteLine("Nota 2.....................:" + alunoIfroDados.Nota2);
    Console.WriteLine("Média.....................:" + alunoIfroDados.CalcularMedia());
    if (alunoIfroDados.CalcularMedia() < 60) Console.ForegroundColor = Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Situação.....................:" + alunoIfroDados.MostrarSituacao());
    Console.ForegroundColor = ConsoleColor.White;


}


/*
Aluno alunoIfro = new Aluno();
alunoIfro.Id = 1;
alunoIfro.NumeroDeMatricula = 3001;
alunoIfro.Nome = "LUIZ";
alunoIfro.Nota1 = 0;
alunoIfro.Nota2 = 0;

Console.WriteLine("Id.....................:"+alunoIfro.Id);
Console.WriteLine("Matrícula.....................:" + alunoIfro.NumeroDeMatricula);
Console.WriteLine("Nome.....................:" + alunoIfro.Nome);
Console.WriteLine("Nota 1.....................:" + alunoIfro.Nota1);
Console.WriteLine("Nota 2.....................:" + alunoIfro.Nota2);
Console.WriteLine("Média.....................:"+ alunoIfro.CalcularMedia());
Console.WriteLine("Situação.....................:" + alunoIfro.MostrarSituacao());
*/
Console.ReadKey();

