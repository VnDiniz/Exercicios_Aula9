namespace ConceitoGravacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                string path = @"C:\Users\vinicius.reolon\Music\ArquivosTextos\saida4.txt";
                string[] linhas = { "Curso 1: C#", "Curso 2: Asp.NET Core", "Curso 3: PHP" };
                string[] inserir = { "Curso 4: Html + CSS", "Curso 5: UX Design", "Curso 6: Laravel" };
                
                File.AppendAllLines(path, inserir);
                Console.WriteLine("Dados inseridos no arquivo 'saida4'");
            }
            catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

        }
    }
}