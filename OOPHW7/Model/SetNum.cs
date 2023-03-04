using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7
{
    public class SetNum{
        protected double real;
        protected double imagine;
        public double Real{
            get{return real;}
            set{this.Real = real;}
        }
        
        public double Imagine{
            get{return imagine;}
            set{this.Imagine = imagine;}
        }
    }
}