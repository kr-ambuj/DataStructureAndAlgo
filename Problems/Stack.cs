using System.Collections;
using System.Collections.Generic;

namespace DataStructureAndAlgo.Problems
{
    internal class Stack : IEnumerable
    {
        public int Size { get; set; }
        public int[] StackArray { get; set; }
        public int Top = -1;

        public Stack(int maxSize)
        {
            Size = maxSize;
            StackArray = new int[Size];
        }

        public void Push(int item)
        {
            Top++;
            StackArray[Top] = item;
        }

        public void Pop()
        {
            StackArray[Top] = 0;
            Top--;
        }

        public int Peek()
        {
            return StackArray[Top];
        }

        public IEnumerator GetEnumerator()
        {
            return StackArray.GetEnumerator();
        }

        internal bool IsEmpty()
        {
            return Top == -1;
        }
    }
}
