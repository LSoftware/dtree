using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Fragments
{
    abstract class BinaryResultFragment:AbstractFragment
    {
        public IResultFragment LeftHandSide => (IResultFragment) Children[0] ;
        public IResultFragment RightHandSide => (IResultFragment) Children[1];
        public override bool Validate()
        {
            return Children.Count == 2 && Children.All(x => x is IResultFragment) && Children.All(x=> x.Validate());
        }
    }
}
