internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("pls enter a stasrtup num ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("pls enter a end num ");
        int num2 = int.Parse(Console.ReadLine());
        int summation = 0;
        for(int i = num1; i <= num2; i++ )
        {
            for (int j = 1; j < i; j++)
            {
                if (i % j == 0)
                {
                    summation = summation + j;
                }
            }
            if(i == summation)
            {
                Console.WriteLine("the perfect numbers from num1 to num2 is {0}" ,i);
            }
           
            
                summation = 0;
            
             
            

        }
       


    }
}