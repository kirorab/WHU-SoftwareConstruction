using System;
using System.Collections.Generic;

namespace sieveOfEratosthenes;

internal class PrsieveOfEratosthenesogram
{
    bool [] b;

    public PrsieveOfEratosthenesogram(int n)
    {
        b = new bool[n];
        for (int i = 0; i < b.Length; i++)
        {
            b[i] = true;
        }
    }

    private void removeNonPrime(int i)
    {
        for (int j = 2*i; j < b.Length; j+=i)
        {
            b[j] = false;
        }
    }

    public void prsieve()
    {
        for (int i = 2; i*i <= 100; i++)
        {
            if (b[i])
            {
                removeNonPrime(i);
            }
        }
    }

    public void printOut()
    {
        for (int i = 2; i < b.Length; i++)
        {
            if (b[i])
            {
                Console.Write(i + " ");
            }
        }
    }
    
    public static void Main(string[] args)
    {
        PrsieveOfEratosthenesogram p = new PrsieveOfEratosthenesogram(101);
        p.prsieve();
        p.printOut();
    }
}

