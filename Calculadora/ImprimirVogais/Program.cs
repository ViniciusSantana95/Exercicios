namespace ImprimirVogais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("Digite um texto:");
            texto = Console.ReadLine();
            int contador = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                char c = char.ToLower(texto[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contador++;
                    Console.Write(c + " ");
                }
            }

            Console.WriteLine("\nO texto contém {0} vogais.", contador);

        }
    }

}
