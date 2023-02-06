namespace Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazem parte do System.IO
            // ReadAllText
            // ReadAllLines
            // ReadAllBytes

            try
            {
                string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\conteudo.txt";
                string texto = File.ReadAllText(path);
                Console.WriteLine(texto);
            }
            catch (Exception e)   // obs: Dependendo do programa ele pode não ter o Exception
            {
                Console.WriteLine(e.Message);
            }

            // Exception
            // IOException
            // FileNotFoundException
        }
    }
}