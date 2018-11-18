using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.nim.ma150129d
{
    public class PlayerHard : Player
    {
        Tree tree;
        int maxDepth;

        public PlayerHard(State state, int maxDepth = 10)
        {
            this.tree = new Tree(state);
            this.maxDepth = maxDepth;
            tree.FormTreeHard(maxDepth);
        }

        public override State PlayMove(State state)
        {
            this.tree = new Tree(state);
            tree.FormTreeHard(maxDepth);
            int val = move(tree.Root, maxDepth, 0);
            int i = 0;
            while (i < tree.Root.Children.Count && val != tree.Root.Children[i].Value)
                i++;
            return i < tree.Root.Children.Count ? tree.Root.Children[i].State : null;
        }

        private int move(Tree.Node node, int maxDepth, int currDepth)
        {
            if (node.State.HeuristicFunction() == 0)
            {
                if (currDepth % 2 == 0)
                    return node.Value = 0;
                else
                    return node.Value = 1;
            }
            if (currDepth == maxDepth)
            {
                if (currDepth % 2 == 0)
                    return node.Value = 1;
                else
                    return node.Value = 0;
            }
            int bestValue, currValue;
            if (currDepth % 2 == 0)
                bestValue = Int32.MinValue;
            else
                bestValue = Int32.MaxValue;
            for (int j = 0; j < node.Children.Count; j++)
            {
                currValue = move(node.Children[j], maxDepth, currDepth + 1);
                if (currDepth % 2 == 0 && currValue > bestValue)
                    bestValue = currValue;
                if (currDepth % 2 == 1 && currValue < bestValue)
                    bestValue = currValue;
            }
            return node.Value = bestValue;
        }
    }
}
