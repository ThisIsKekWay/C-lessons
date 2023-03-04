using System;


namespace OOPHW7
{
    public class Complex : SetNum{
        public Complex(double real, double imagine)
        {
            this.real = real;
            this.imagine = imagine;
        }


    public override String ToString(){
        if (this.real == 0 & this.imagine == 0){
            return "0";
        } else if (this.real == 0){
            return String.Format("{0:f2}j",this.imagine);
        } else if (this.imagine == 0){
            return String.Format("{0:f2}",this.real);
        }
                    
        if (this.imagine < 0){
            return String.Format("{0:f2} - {1:f2}j",this.real,Math.Abs(this.imagine));
        } else{
            return String.Format("{0:f2} + {1:f2}j",this.real,this.imagine);
        }
    }
}
}