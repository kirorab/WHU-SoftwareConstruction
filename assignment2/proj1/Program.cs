

namespace num2PrimeNum;

class num2PrimeNum
{
    private int num;

    public num2PrimeNum(int num)
    {
        this.num = num;
    }
    
    private void divideHelper(int dividsor)
    {
        int order = 0;
        while (num % dividsor == 0)
        {
            order += 1;
            num /= dividsor;
        }
        printPrimeNum(dividsor, order);
    }
    
    private void divide()
    {
        if (num <= 2)
        {
            Console.WriteLine(num);
            return;
        }
        int n = num;
        for (int i = 2; i < n + 1; i++)
        {
            if (num == 1)
            {
                break;
            }
            divideHelper(i);
        }
    }

    private void printPrimeNum(int primeNum, int order)
    {
        if (order == 0)
        {
            return;
        }
        Console.WriteLine(primeNum + "的" + order + "次方");
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Please input a num");
        string read = Console.ReadLine();
        int numRead = Int32.Parse(read);
        num2PrimeNum n = new num2PrimeNum(numRead);
        Console.WriteLine("n是以下这些数的相乘：");
        n.divide();
    }
    
    
}

