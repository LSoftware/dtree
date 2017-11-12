using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Fragments
{
    abstract class ConjunctionFragment: AbstractFragment
    {
        public override bool Validate()
        {
            return Children.Count > 0 && Children.All(x => !(x is IResultFragment) && x.Validate());
        }
    }
}
