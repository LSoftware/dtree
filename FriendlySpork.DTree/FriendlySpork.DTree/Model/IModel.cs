using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlySpork.DTree.Model
{
    interface IModel
    {
        bool IsScalar { get; }
        string Get(string field);
        string[] Fields { get; }
    }
    interface IModel<T> : IModel
    {
        T Scalar { get; }
    }
}
