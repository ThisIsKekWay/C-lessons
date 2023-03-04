using OOPHW7.Model;
using OOPHW7.view;

namespace OOPHW7.Presenter
{
    public class Presenter{
        View view;

        public Presenter(View view) {this.view = view;}

        public void buttonClick(){
        while(true){
            View.greeting();
            String order = view.getValue("Команда: ");

            Model<Complex> var1 = new ComplexCalc();
            Model<Rationals> var2 = new RatioCalc();
            Model<Fractionals> var3 = new FractCalc();

            switch (order) {
                case "1": {
                    String[] a = view.getValue("Введите мнимую и действительную часть числа №1 через пробел: ").Split(" ");
                    Complex c1 = new Complex(Double.Parse(a[0]), Double.Parse(a[1]));
                    a = view.getValue("Введите мнимую и действительную часть числа №2 через пробел: ").Split(" ");
                    Complex c2 = new Complex(Double.Parse(a[0]), Double.Parse(a[1]));

                    View.operation();
                    order = view.getValue("Команда: ");
                    switch (order) {
                        case "1": {var1.sum(c1, c2); break;}
                        case "2": {var1.diff(c1, c2); break;}
                        case "3": {var1.mult(c1, c2); break;}
                        case "4": {var1.div(c1, c2); break;}
                    }
                    break;
                }
                case "2": {
                    String[] a = view.getValue("Введите два рациональных числа через пробел: ").Split(" ");
                    Rationals c1 = new Rationals(Double.Parse(a[0]));
                    Rationals c2 = new Rationals(Double.Parse(a[1]));

                    View.operation();
                    order = view.getValue("Команда: ");
                    switch (order) {
                        case "1": {var2.sum(c1, c2); break;}
                        case "2": {var2.diff(c1, c2); break;}
                        case "3": {var2.mult(c1, c2); break;}
                        case "4": {var2.div(c1, c2); break;}
                    }
                    break;
                }
                case "3": {
                    String[] a = view.getValue("Введите числитель и знаменатель числа №1 через пробел: ").Split(" ");
                    Fractionals c1 = new Fractionals(int.Parse(a[0]), int.Parse(a[1]));
                    a = view.getValue("Введите числитель и знаменатель числа №2 через пробел: ").Split(" ");
                    Fractionals c2 = new Fractionals(int.Parse(a[0]), int.Parse(a[1]));


                    View.operation();
                    order = view.getValue("Команда: ");
                    switch (order) {
                        case "1": {var3.sum(c1, c2); break;}
                        case "2": {var3.diff(c1, c2); break;}
                        case "3": {var3.mult(c1, c2); break;}
                        case "4": {var3.div(c1, c2); break;}
                    }
                    break;
                }
                    case "0":{ Environment.Exit(0); break;}
                }
            }
        }
    }
}