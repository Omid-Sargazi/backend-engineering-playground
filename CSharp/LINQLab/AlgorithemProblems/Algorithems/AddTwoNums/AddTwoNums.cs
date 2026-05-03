using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithems.AddTwoNums
{
    public class AddTwoNums
    {
        public int[] Execute(int[] args, int target)
        {
            int left = 0; int right = args.Length;
            for(int i = left; i<=right;i++)
            {
                if (args[left] + args[right]==target)
                {
                    return [left, right];
                }
                left++;
                right--;
            }
            return [0,0];
        }
    }

    public int[] Execute2(int[] args, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < args.Length; i++)
            {
                int complement = target - args[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[args[i]] = i;
            }
            return new int[] { -1, -1 };
        }
    }
