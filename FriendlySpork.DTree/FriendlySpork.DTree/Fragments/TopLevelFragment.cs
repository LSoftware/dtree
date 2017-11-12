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
        
        

        public string Name { get; set; }

        public string[] RequiredFields { get; set; }

        public DateTime? ValidStart { get; set; }

        public DateTime? ValidEnd { get; set; }

        public override bool Evaluate(IModel m)
        {
            return Children[1].Evaluate(m);

        }

        public IComparable GetResult(IModel m)
        {
            var c = Children[0] as IResultFragment;
            return c.GetResult(m);
        }

        public override bool Validate()
        {
            return Children.Count == 2 && Children[0] is IResultFragment &&  (!(Children[1] is IResultFragment)) && Children.All(x=> x.Validate());            
        }
    }
}
