using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Fragments
{
    interface IRule:IFragment
    {
        string Name { get; }
        string[] RequiredFields { get; }
        DateTime? ValidStart { get; }
        DateTime? ValidEnd { get; }
    }
}
