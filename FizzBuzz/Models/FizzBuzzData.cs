using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class FizzBuzzData
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }
        public List<string> Result { get; set; } = new();
    }
}
