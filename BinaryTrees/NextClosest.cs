using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public static class NextClosest
    {
        public static int NextClosestItem(Node current, int desiredValue, int closest)
        {
            if (current == null)
            {
                return closest;
            }

            var currentDiff = Math.Abs(current.Data - desiredValue);
            var closestDiff = Math.Abs(closest - desiredValue);

            if (closest == int.MinValue)
            {
                closest = current.Data;
            }
            else
            {
                if (currentDiff < closestDiff)
                {
                    closest = current.Data;
                }
            }

            if (desiredValue == current.Data)
            {
                return closest;
            }
            else if (desiredValue > current.Data)
            {
                return NextClosestItem(current.Right, desiredValue, closest);
            }
            else
            {
                return NextClosestItem(current.Left, desiredValue, closest);
            }
        }
    }
}
