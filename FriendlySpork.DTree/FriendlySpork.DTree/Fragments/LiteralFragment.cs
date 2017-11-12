using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class LiteralFragment : LeafResultFragment
    {
        IComparable Literal { get; set; }
        public override IComparable GetResult(IModel m)
        {
            return Literal;
        }
    }
}
