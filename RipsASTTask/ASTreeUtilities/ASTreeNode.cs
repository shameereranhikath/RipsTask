using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr.Runtime.Tree;

namespace RipsASTTask.ASTreeUtilities
{
    public class ASTreeNode:IASTreeNode
    {
         ITree _tree;

        public ASTreeNode(ITree tree)
        {
            _tree = tree;
        }

        public string Text
        {
            get { return _tree.Text; }
        }

        public int Count
        {
            get { return _tree.ChildCount; }
        }

        public IEnumerable<IASTreeNode> Children
        {
            get
            {
                for (int i = 0; i < _tree.ChildCount; ++i)
                {
                    yield return new ASTreeNode(_tree.GetChild(i));
                }
            }
        }

    }
}
