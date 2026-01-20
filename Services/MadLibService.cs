using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services
{
    public class MadLibService
    {
        public string CreateStory(string name, string place, string verb)
        {
            return $"{name} went to {place} and decided to {verb} all day.";
        }
    }
}
