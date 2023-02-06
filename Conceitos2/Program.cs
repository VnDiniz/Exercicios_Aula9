namespace Conceitos2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // No ReadAllLines ele coloca cada linha do texto dentro de um array (mais interessante para manipular os dados)

            string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\conteudo.txt";
            string[] linhas = File.ReadAllLines(path);

            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("\n" + linhas[2]);
            Console.WriteLine("\n" + linhas[4]);

        }
    }
}