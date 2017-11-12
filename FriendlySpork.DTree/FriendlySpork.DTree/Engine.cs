using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendlySpork.DTree.Fragments;
using FriendlySpork.DTree.Model;

namespace FriendlySpork.DTree
{
    /// <summary>
    /// 
    /// </summary>
    class Engine
    {
        public Engine()
        {
            RulesStorage = new Dictionary<string, IRule>();
        }
        public IModel Evaluate(string rule, IModel input, DateTime evalDate)
        {
            return null;
        }
        public void Add(string ruleDef)
        {

        }
        Dictionary<string, IRule> RulesStorage;

    }
}
