namespace ConceitosGravacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\saida1.txt";
                string conteudo = "Conteudo: Gravando dados com WriteAllText ";
                File.WriteAllText(path, conteudo);
                Console.WriteLine("Arquivo criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Algo deu errado, arquivo não criado!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}