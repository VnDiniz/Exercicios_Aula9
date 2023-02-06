namespace ConceitoGravacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\saida4.txt";
                string[] inserir = { "Curso 7: JavaScript" };

                if (File.Exists(path))
                {
                    File.AppendAllLines(path, inserir);
                    Console.WriteLine("Dados inseridos no arquivo 'saida4'.");
                }
                else
                {
                    File.WriteAllLines(path, inserir);
                    Console.WriteLine("Arquivo Criado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}