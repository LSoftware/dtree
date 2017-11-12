using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Fragments
{
    abstract class UnaryResultFragment : AbstractFragment
    {
        public IResultFragment Child { get { return (IResultFragment)Children[0]; } }
        public override bool Validate()
        {
            return Children.Count == 1 && Children.All(x => x is IResultFragment);
        }
    }
}
