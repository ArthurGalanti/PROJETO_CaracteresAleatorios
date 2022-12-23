var quantidadeNomes = 99;
var quantidadeLetras = 16;
string nome;
var listaCaracteres = new char[] { ' ', ' ', ' ' };
var rand = new Random();

for (int i = 0; i < quantidadeNomes; i++)
{
    nome = $"{(i + 1).ToString("00")}.|";
    for (int j = 0; j < quantidadeLetras; j++)
    {
        nome += listaCaracteres[rand.Next(0, listaCaracteres.Length)];

    }
    nome += "|";
    Console.WriteLine(nome);
}