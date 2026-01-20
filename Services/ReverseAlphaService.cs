using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FivetoSeven.Services
{
    public class ReverseAlphaService
    {
        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }

}