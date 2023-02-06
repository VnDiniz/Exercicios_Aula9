namespace Conceitos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\conteudo.txt";

            byte[] bytes = File.ReadAllBytes(path);

            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(bytes[i] + " ");

                if (i > 0 && i % 20 == 00)  // a cada 21 escritas pula uma linha
                {
                    Console.WriteLine();
                }
            }

        }
    }
}