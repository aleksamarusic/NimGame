using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.nim.ma150129d
{
    public class PlayerAlphaBeta : Player
    {
        Tree tree;
        int maxDepth;

        public PlayerAlphaBeta(State state, int maxDepth = 10)
        {
            this.tree = new Tree(state);
            this.maxDepth = maxDepth;
            tree.formTree(maxDepth);
        }

        public override State PlayMove(State state)
        {
            this.tree = new Tree(state);
            tree.formTree(maxDepth);
            int val = AlphaBeta(tree.Root, maxDepth, 0, Int32.MinValue, Int32.MaxValue);
            int i = 0;
            while (i < tree.Root.Children.Count && val != tree.Root.Children[i].Value)
                i++;
            return i < tree.Root.Children.Count ? tree.Root.Children[i].State : null;
        }

        private int AlphaBeta(Tree.Node node, int maxDepth, int currDepth, int alpha, int beta)
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
                currValue = AlphaBeta(node.Children[j], maxDepth, currDepth + 1, alpha, beta);
                if (currDepth % 2 == 0 && currValue > bestValue)
                {
                    bestValue = currValue;
                    if (bestValue >= beta)
                    {
                        j = node.Children.Count;
                        return node.Value = bestValue;
                    }
                    alpha = Math.Max(alpha, bestValue);
                }
                if (currDepth % 2 == 1 && currValue < bestValue)
                {
                    bestValue = currValue;
                    if (bestValue <= alpha)
                    {

                        return node.Value = bestValue;
                    }
                    beta = Math.Min(beta, bestValue);
                }
            }
            return node.Value = bestValue;
        }
    }
}
