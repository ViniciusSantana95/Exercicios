namespace LeitorString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            Console.WriteLine("Informe uma palavra");
            palavra = Console.ReadLine();

            int contador = 0;

            for (int i = 0; i < palavra.Length; i++)
            {
                char c = char.ToLower(palavra[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contador++;
                }
            }

            Console.WriteLine("O texto contém {0} vogais.", contador);

        }
    }
}