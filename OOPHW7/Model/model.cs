using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPHW7{
    public interface Model<T>
    {
        public  T sum(T t1, T t2);
        public T diff(T t1, T t2);
        public T div(T t1, T t2);
        public T mult(T t1, T t2);
    }
}
