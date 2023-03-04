using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7.Model{
    public class Rationals : SetNum{
        public Rationals(double real){
            this.real = real;
        }

    public override String ToString(){
        return String.Format("{0:f2}", this.real);
        }
    }
}