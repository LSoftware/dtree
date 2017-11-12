﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree.Fragments
{
    class NotFragment : ConjunctionFragment
    {
        public override bool Evaluate(IModel m)
        {
            return !Children[0].Evaluate(m);
        }
    }
}
