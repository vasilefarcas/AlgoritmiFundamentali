using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_2022
{
    internal class Engine
    {
        public Cplx sum(Cplx a, Cplx b)
        {
            Cplx t =new Cplx();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            return t;
        }
        /*
        public static Cplx operator + (Cplx a, Cplx b)
        {
            Cplx t = new Cplx();
            t.re = a.re + b.re;
            t.im = a.im + b.im;
            return t;
        }
        */
    }
}
