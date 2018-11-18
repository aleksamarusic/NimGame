using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.nim.ma150129d
{
   
    public class Tree
    {
        public class Node
        {
            //private int maxDepth;

            int depth;
            State state;
            private List<Node> children = new List<Node>();
            int value;
            public Node(State state)
            {
                this.State = state;
            }

            public int Depth { get => depth; set => depth = value; }
            public State State { get => state; set => state = value; }
            public List<Node> Children { get => children; set => children = value; }
            public int Value { get => value; set => this.value = value; }

            //public int MaxDepth { get => maxDepth; set => maxDepth = value; }

            public void addChild(Node n)
            {
                Children.Add(n);
            }
        }
        Node root;
        int initDepth;
        public Node Root { get => root; set => root = value; }

        public Tree(State state, int Depth = 0)
        {
            Root = new Node(state);
            initDepth = Depth;
            root.Depth = Depth;
        }

        public void formTree(int depth)
        {
            int i = 0;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            int q = 1;
            while (i < depth)
            {

                int p = q;
                q = 0;
                while (p-- > 0)
                {
                    Node tmp = queue.Dequeue();
                    int a = 5;
                    for (int j = 0; j < tmp.State.NumberOfPillars; j++)
                    {
                        for (int k = 1; k <= tmp.State.NumbersOfRings[j]; k++)
                            if (tmp.State.Check(j, k))
                            {
                                Node newOne = new Node(tmp.State.NewState(j, k));
                                newOne.Depth = tmp.Depth + 1;
                                //newOne.MaxDepth = tmp.MaxDepth;
                                tmp.addChild(newOne);
                                queue.Enqueue(newOne);  
                                q++;
                            }
                    }
                }
                i++;
            }
        }

        public void FormTreeHard(int depth)
        {
            int i = 0;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);
            int q = 1;
            while (i < depth)
            {

                int p = q;
                q = 0;
                while (p-- > 0)
                {
                    Node tmp = queue.Dequeue();
                    Dictionary<int, int> dictionary = new Dictionary<int, int>();
                    for (int j = 0; j < tmp.State.NumberOfPillars; j++)
                        dictionary.Add(tmp.State.NumbersOfRings[j], j);
                    while(dictionary.Count != 0)
                    {
                        int j = dictionary.Keys.Max();
                        for (int k = tmp.State.NumbersOfRings[dictionary[j]]; k>=0; k--)
                            if (tmp.State.Check(j, k))
                            {
                                Node newOne = new Node(tmp.State.NewState(dictionary[j], k));
                                newOne.Depth = tmp.Depth + 1;
                                //newOne.MaxDepth = tmp.MaxDepth;
                                tmp.addChild(newOne);
                                queue.Enqueue(newOne);
                                q++;
                            }
                        dictionary.Remove(j);
                    }
                }
                i++;
            }
        }

    }
}
