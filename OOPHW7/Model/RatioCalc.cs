using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.Model
{
    public class RatioCalc : SetNum, Model<Rationals>
    {
        Rationals Model<Rationals>.diff(Rationals t1, Rationals t2)
        {
           Rationals res = new Rationals(t1.Real - t2.Real);
            Logger.log(String.Format("{0} - {1} = {2}\n",t1, t2, res));
            return res;
        }

        Rationals Model<Rationals>.div(Rationals t1, Rationals t2)
        {
            Rationals res = new Rationals(t1.Real / t2.Real);
            Logger.log(String.Format("{0} / {1} = {2}\n",t1, t2, res));
            return res;
        }

        Rationals Model<Rationals>.mult(Rationals t1, Rationals t2)
        {
            Rationals res = new Rationals(t1.Real * t2.Real);
            Logger.log(String.Format("{0} * {1} = {2}\n",t1, t2, res));
            return res;
        }

        Rationals Model<Rationals>.sum(Rationals t1, Rationals t2)
        {
            Rationals res = new Rationals(t1.Real + t2.Real);
            Logger.log(String.Format("{0} + {1} = {2}\n",t1, t2, res));
            return res;
        }
    }
}