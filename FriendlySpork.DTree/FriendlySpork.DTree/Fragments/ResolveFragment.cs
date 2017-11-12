using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class ResolveFragment : LeafResultFragment
    {
        public string Field { get; set; }
        public IComparable GetResult(IModel m)
        {
            return m.Get(Field);
        }        
    }
}
