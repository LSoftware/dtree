using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    abstract class LeafResultFragment : AbstractFragment, IResultFragment
    {
        public override bool Evaluate(IModel m)
        {
            return true;
        }

        public abstract IComparable GetResult(IModel m);
        

        public override bool Validate()
        {
            return Children.Count == 0;
        }
    }
}
