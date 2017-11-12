using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class GreaterFragment:BinaryResultFragment
    {
        public override bool Evaluate(IModel m)
        {
            IComparable a = LeftHandSide.GetResult(m);
            IComparable b = RightHandSide.GetResult(m);
            return a.CompareTo(b) > 0;
        }      
    }
}
