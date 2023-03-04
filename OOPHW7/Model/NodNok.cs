using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.Model
{
    public interface NodNok
    {
        static int gcd(int a,int b) {
            while (b !=0) {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }

        static int lcm(int a, int b){
            return a * b / gcd(a, b);
        }
    }
}