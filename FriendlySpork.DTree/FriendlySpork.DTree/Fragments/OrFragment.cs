using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Fragments
{
    class OrFragment : ConjunctionFragment
    {
        public override bool Evaluate(IModel m)
        {
            bool eval = false;
            for (int index = 0; !eval && index < Children.Count; index++)
            {
                eval = Children[index].Evaluate(m);
            }
            return eval;
        }
    }
}
