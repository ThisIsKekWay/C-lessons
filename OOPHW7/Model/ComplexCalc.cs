using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7
{
    public class ComplexCalc : SetNum, Model<Complex>
    {
        Complex Model<Complex>.diff(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.Real - c2.Real, c1.Imagine - c2.Imagine);
            Logger.log(String.Format("{0} - {1} = {2}\n",c1, c2, res));
            return res;
        }

        Complex Model<Complex>.div(Complex c1, Complex c2)
        {
            double denom = Math.Pow(c2.Real, 2) + Math.Pow(c2.Imagine, 2);
            double resReal = (c1.Real * c2.Real + c1.Imagine * c2.Imagine) / denom;
            double resImg = (c1.Imagine * c2.Real - c1.Real * c2.Imagine) / denom;
            Complex res = new Complex(resReal, resImg);
            Logger.log(String.Format("{0} / {1} = {2}\n",c1, c2, res));
            return res;
        }

        Complex Model<Complex>.mult(Complex c1, Complex c2)
        {
            double resReal = c1.Real * c2.Real - c1.Imagine * c2.Imagine;
            double resImg = c1.Imagine * c2.Real + c1.Real * c2.Imagine;
            Complex res = new Complex(resReal, resImg);
            Logger.log(String.Format("{0} * {1} = {2}\n",c1, c2, res));
            return res;
        }

        Complex Model<Complex>.sum(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.Real + c2.Real, c1.Imagine + c2.Imagine);
            Logger.log(String.Format("{0} + {1} = {2}\n", c1, c2, res));
            return res;
        }
    }
}