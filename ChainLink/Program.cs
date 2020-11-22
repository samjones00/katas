using System;
using System.Collections.Generic;

namespace ChainLink
{
    using System;

    public enum Side { None, Left, Right }

    public class ChainLinkEnd : ChainLink
    {
        public int LeftTotal { get; set; }
        public int RightTotal { get; set; }
    }

    public class ChainLink
    {
        public ChainLink Left { get; private set; }
        public ChainLink Right { get; private set; }

        public void Append(ChainLink rightPart)
        {
            if (this.Right != null)
                throw new InvalidOperationException("Link is already connected.");

            this.Right = rightPart;
            rightPart.Left = this;
        }

        public Side LongerSide()
        {
            var leftCount = 0;
            CountChildren(Left, ref leftCount);

            var rightCount = 0;
            CountChildren(Right, ref rightCount);


            if (leftCount > rightCount)
                return Side.Left;

            if (rightCount > leftCount)
                return Side.Right;

            return Side.None;
        }

        private int CountChildren(ChainLink link, ref int count)
        {
            if (link == null)
                return count; 

            if (link.Left == null && link.Right == null)
                return count; 

            count++;

            if (link.Left != null)
            {
                return CountChildren(link.Left, ref count);
            }

            if (link.Right != null)
            {
                return CountChildren(link.Right, ref count);
            }

            return count;
        }

        public static void Main(string[] args)
        {
            ChainLink left = new ChainLink();
            ChainLink middle = new ChainLink();
            ChainLink right = new ChainLink();
            left.Append(middle);
            middle.Append(right);
            Console.WriteLine(left.LongerSide());
        }
    }
}
