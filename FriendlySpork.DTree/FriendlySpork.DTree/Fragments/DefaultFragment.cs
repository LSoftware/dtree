using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class DefaultFragment : AbstractFragment, IResultFragment
    {
        public DefaultFragment(IComparable val)
        {
            TrueResult = val;
        }
        public IComparable TrueResult { get; set; }

        public override bool Evaluate(IModel m)
        {
            return true;
        }

        public IComparable GetResult(IModel m)
        {
            return TrueResult;
        }

        public override bool Validate()
        {
            return true;
        }
    }
}
