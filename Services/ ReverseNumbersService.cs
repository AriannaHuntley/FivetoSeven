using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FivetoSeven.Services
{
    public class ReverseNumbersService
    {
        public string ReverseNumbers(string numbers)
        {
            char[] chars = numbers.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

}