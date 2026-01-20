using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class OddOrEvenService
{
    public string Check(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}
