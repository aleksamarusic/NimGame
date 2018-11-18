using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.nim.ma150129d
{
    public class State
    {
        private int numberOfPillars;
        private int[] numbersOfRings;
        private int possibleNumberOfRingsToTake;

        public int NumberOfPillars { get => numberOfPillars; set => numberOfPillars = value; }
        public int[] NumbersOfRings { get => numbersOfRings; set => numbersOfRings = value; }
        public int PossibleNumberOfRingsToTake { get => possibleNumberOfRingsToTake; set => possibleNumberOfRingsToTake = value; }

        public State(int[] array, int pnrt, int n = 5)
        {
            NumbersOfRings = array;
            PossibleNumberOfRingsToTake = pnrt;
            NumberOfPillars = n;
        }

        public int FindDifference(State state)
        {
            HashSet<int> set = new HashSet<int>();
            int counter = 0;
            for (int i = 0; i < 10; i++)
                if (NumbersOfRings[i] != 0)
                    set.Add(NumbersOfRings[i]);
            for (int i = 0; i < 10; i++)
                if (state.NumbersOfRings[i] != 0)
                    if (!set.Contains(state.NumbersOfRings[i]))
                        counter++;
            return counter;
        }

        public int FindDifference(int[] array)
        {
            HashSet<int> set = new HashSet<int>();
            int counter = 0;
            for (int i = 0; i < 10; i++)
                if (NumbersOfRings[i] != 0)
                    set.Add(NumbersOfRings[i]);
            for (int i = 0; i < 10; i++)
                if (array[i] != 0)
                    if (!set.Contains(array[i]))
                        counter++;
            return counter;
        }

        public int HeuristicFunction()
        {
            int xor = 0;
            for (int i = 0; i < NumberOfPillars; i++)
                xor ^= NumbersOfRings[i];
            return xor > 0 ? 1 : 0;
        }
        private bool CheckUnique(int p, int r)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = NumbersOfRings[i];
            int pnrt = r * 2;
            arr[p] -= r;
            HashSet<int> numOfRings = new HashSet<int>();
            for (int i = 0; i < NumberOfPillars; i++)
            {
                if (arr[i] != 0)
                {
                    if (numOfRings.Contains(arr[i]))
                        return false;
                    else
                        numOfRings.Add(arr[i]);
                }
            }
            return true;
        }

        public bool Check(int pillar, int rings)
        {
            if (CheckUnique(pillar, rings) == false)
                return false;
            if (rings > PossibleNumberOfRingsToTake)
                return false;
            return true;
        }

        public State NewState(int pillar, int rings)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = NumbersOfRings[i];
            int pnrt = rings * 2;
            arr[pillar] -= rings;
            return new State(arr, pnrt);
        }
    }
}
