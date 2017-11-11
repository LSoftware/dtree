using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
     abstract class AbstractFragment : IFragment
    {
        
        public  List<IFragment> Children { get; private set; }

        public virtual IFragment Parent { get; private set; }

        public abstract bool Evaluate(IModel m);
        public abstract bool Validate();
        
    }
}
