using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class AndFragment : ConjunctionFragment
    {
        public override bool Evaluate(IModel m)
        {
            bool eval=true;           
            for(int index =0; eval && index < Children.Count ; index++)
            {
                eval = Children[index].Evaluate(m);                
            }
            return eval;
        }      
    }
}
