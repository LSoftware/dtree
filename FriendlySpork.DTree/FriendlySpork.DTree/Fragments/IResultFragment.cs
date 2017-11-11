using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    interface IResultFragment:IFragment
    {
        IComparable GetResult(IModel m);
       
    }
}
