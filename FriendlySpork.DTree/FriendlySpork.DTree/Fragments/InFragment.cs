using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class InFragment:AbstractFragment
    {
        public override bool Evaluate(IModel m)
        {
            bool found = false;
            var src = ((IResultFragment)Children[0]).GetResult(m);
            for(int i =1;!found && i< Children.Count; i++)
            {
                var mat = ((IResultFragment)Children[0]).GetResult(m);
                found = src.CompareTo(mat) == 0;
            }
            return found;
        }

        public override bool Validate()
        {
            return Children.Count >= 2 && Children.All(x => x is IResultFragment) && Children.All(x => x.Validate());
        }
    }
}
