using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
        }
    }
}
