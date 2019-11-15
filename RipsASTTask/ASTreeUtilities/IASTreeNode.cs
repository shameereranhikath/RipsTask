using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipsASTTask.ASTreeUtilities
{
    public interface IASTreeNode
    {
        string Text { get; }
        int Count { get; }
        IEnumerable<IASTreeNode> Children { get; }
    }
}
