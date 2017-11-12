using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class ExclusiveOrFragment : AbstractFragment
    {
        public override bool Evaluate(IModel m)
        {
            int count = 0;
            for(int i=0;i<Children.Count && count < 2;i++)
            {
                if (Children[i].Evaluate(m))
                {
                    count++;
                }
            }
            if (count == 1)
                return true;
            return false;
        }

        public override bool Validate()
        {
            return Children.Count > 1 && Children.All(x => !(x is IResultFragment));
        }
    }
}
