
class Program
{
    static void Main()
    {

        int[] quantidade = new int[30]; 
        Console.Write("Insira o número de valores a serem ordenados : ");
        int numeros = int.Parse(Console.ReadLine());
  
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Insira o numero " + i + ":");
            quantidade[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= numeros; i++)
        {
            for (int num = 1; j <= numeros - 1; num++)
            {
                if (quantidade[num] > quantidade[num + 1])
                {
                    int temp = quantidade[num];
                    quantidade[num] = quantidade[num + 1];
                    quantidade[num + 1] = temp;
                }
            }
        }
        Console.Write("Ordenados de maneira ascendente : ");
        for (i = 1; i <= n; i++)
        {
            Console.Write(a[i] + " ");
        }
    }
}