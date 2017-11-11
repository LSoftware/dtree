using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class EqualFragment : AbstractFragment
    {
        public override bool Evaluate(IModel m)
        {
            List<IComparable> res = Children.Select(x => (x as IResultFragment).GetResult(m)).ToList();
            if (res.Count > 1)
            {
                bool rtn = true;
                for (int i = 0; rtn && i < res.Count - 1; i++)
                {
                    rtn = res[i].CompareTo(res[i + 1]) == 0;
                }
            }
            return false;
        }

        public override bool Validate()
        {
            return Children.Count > 1 && Children.All(x => x is IResultFragment && x.Validate());
        }
    }
}
