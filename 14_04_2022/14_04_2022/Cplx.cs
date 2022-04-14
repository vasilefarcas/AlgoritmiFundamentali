using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_04_2022
{
    public class Cplx
    {
        public float re, im;
        public void init(float _re, float _im)
        { re = _re; im = _im; }
        public string view()
        {
            if (im >= 0)
                return re + " + i" + im;
            return re + " - i" + (im * -1);
        }

        public Cplx sum(Cplx a)
        {
            Cplx t = new Cplx();
            t.re = re + a.re;
            t.im = im + a.im;
            return t;
        }
    }
}
