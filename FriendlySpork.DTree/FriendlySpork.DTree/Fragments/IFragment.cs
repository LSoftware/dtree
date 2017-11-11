using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    interface IFragment
    {
        List<IFragment> Children { get;}
        IFragment Parent { get; }
        bool Evaluate(IModel m);
        bool Validate();

    }
}
