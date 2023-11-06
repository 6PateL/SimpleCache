using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cache cache = new Cache(100);

            int[] ints = { 1, 2, 3, 4, 5 };
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            for (int i = cache.Count; i < ints.Length; i++)
            {
                cache.SetData(i, ints[i]);
            }
            for (int j = cache.Count; j < chars.Length; j++)
            {
                cache.SetData(j, chars[j]);
            }
        }
    }
}
