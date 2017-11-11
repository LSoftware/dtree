using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class TopLevelFragment : AbstractFragment, IRule, IResultFragment
    {
        public IComparable TrueResult { get; set; }
        

        public string Name { get; set; }

        public string[] RequiredFields { get; set; }

        public DateTime? ValidStart { get; set; }

        public DateTime? ValidEnd { get; set; }

        public override bool Evaluate(IModel m)
        {
           IResultFragment first = Children.First(x => x.Evaluate(m)) as IResultFragment;
           if(first != null)
            {
                TrueResult = first.TrueResult;
            }
            return first != null;

        }

        public override bool Validate()
        {
            return Children.All(x => x is IResultFragment && x.Validate());
            
        }
    }
}
