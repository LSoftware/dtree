using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class ReferenceFragment : AbstractFragment,IResultFragment
    {
        public IResultFragment Resolved => (IResultFragment)Children[0];
        public string RefName { get; set; }
        public override bool Evaluate(IModel m)
        {
            return Resolved.Evaluate(m);
        }

        public IComparable GetResult(IModel m)
        {
            return Resolved.GetResult(m);
        }

        public override bool Validate()
        {
            return Children.Count == 1 && Children[0] is TopLevelFragment;
        }
    }
}
