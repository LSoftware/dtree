using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class ExistsFragment : UnaryResultFragment
    {
        public override bool Evaluate(IModel m)
        {
           
            return Child.GetResult(m) != null;

        }


    }
}
