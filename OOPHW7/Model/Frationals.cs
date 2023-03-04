using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.Model
{
    public class Fractionals
    {
        protected internal int numerator;
        protected internal int denominator;
        protected internal int wholePart;

        public Fractionals(int numerator, int denominator) {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override String ToString(){
            wholePart = numerator / denominator;
            if(wholePart != 0){
                int newNumerator = numerator % denominator;
                if(newNumerator == 0){
                    return String.Format("{0}",wholePart);
                }

                return String.Format("{0} {1}/{2}",wholePart, newNumerator, denominator);
            } else {
                if (numerator == 0){
                    return "0";
                }
                if (numerator < 0 | denominator < 0){
                    return String.Format("-{0}/{1}",Math.Abs(numerator), Math.Abs(denominator));
                } else {
                    return String.Format("{0}/{1}",Math.Abs(numerator), Math.Abs(denominator));
                }
            }
        }
    }
}