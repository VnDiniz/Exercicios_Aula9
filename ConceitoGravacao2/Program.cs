namespace ConceitoGravacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\saida2.txt";
                string[] linhas = { "Curso 1: C#", "Curso 2: Asp.NET Core", "Curso 3: PHP" };
                File.WriteAllLines(path, linhas);
                Console.WriteLine("Arquivo 'saida2' criado");

                string path2 = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\saida3.txt";
                byte[] bytes = { 73, 109, 112, 97, 99, 116, 97, 32, 84, 101, 99, 110, 111, 108, 111, 103, 105, 97 };
                File.WriteAllBytes(path2, bytes);
                Console.WriteLine("Arquivo 'saida3' criado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}