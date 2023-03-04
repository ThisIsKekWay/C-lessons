using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.Model
{
    public class FractCalc : Model<Fractionals>, NodNok{
        Fractionals Model<Fractionals>.diff(Fractionals r1, Fractionals r2){
            String s = String.Format("{0} - {1} = ", r1, r2);
            int nok = NodNok.lcm(r1.denominator, r2.denominator);
            r1.numerator = r1.numerator * (nok / r1.denominator);
            r2.numerator = r2.numerator * (nok / r2.denominator);
            Fractionals res = new Fractionals(r1.numerator - r2.numerator, nok);
            Logger.log(String.Format("{0} {1}\n", s, res));
            return res;
        }

        Fractionals Model<Fractionals>.div(Fractionals r1, Fractionals r2)
        {
            Fractionals res = new Fractionals(r1.numerator * r2.denominator, r1.denominator * r2.numerator );
            Logger.log(String.Format("{0} / {1} = {2}\n", r1, r2, res));
            return res;
        }

        Fractionals Model<Fractionals>.mult(Fractionals r1, Fractionals r2)
        {
            Fractionals res = new Fractionals(r1.numerator * r2.numerator, r1.denominator * r2.denominator);
            Logger.log(String.Format("{0} * {1} = {2}\n", r1, r2, res));
            return res;
        }

        Fractionals Model<Fractionals>.sum(Fractionals r1, Fractionals r2){
            String s = String.Format("{0} + {1} = ", r1, r2);
            int nok = NodNok.lcm(r1.denominator, r2.denominator);
            r1.numerator = r1.numerator * (nok / r1.denominator);
            r2.numerator = r2.numerator * (nok / r2.denominator);
            Fractionals res = new Fractionals(r1.numerator + r2.numerator, nok);
            Logger.log(String.Format("{0} {1}\n", s, res));
            return res;
        }
    }
}