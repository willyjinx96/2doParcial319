using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaParcial
{
    public class Fibonacci
    {
        public long[] genera(int n)
        {
            long[] lista = new long[n];
            long a = 0;
            long b = 1;
            long c = 1;
            long f = 0;
            for (int i = 0; i < n; i++)
            {
                f = a + b + c;
                lista[i] = f;
                a = b;
                b = c;
                c = f;
            }
            return lista;
        }
    }
}
