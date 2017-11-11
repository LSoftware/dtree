using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Model
{
    class Result
    {
       public ResultType TypeOfResult { get; }
       public bool Evaluated { get; set; }
        public virtual object ResultValue {  get; set; }
        
    }
    class Result<T> : Result where T:class
    {
        public  T Value { get { return ResultValue as T; } set { ResultValue = value; } } 
    }

}
