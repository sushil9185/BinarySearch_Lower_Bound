using System.Net.NetworkInformation;

namespace BinarySearch_Lower_Bound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 2, 3];
            int x = 2;
            Console.WriteLine(Search(arr, x));
        }

        public static int Search(int[] nums,int x)
        {
            int n = nums.Length, ans = n, low = 0, high = n - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (nums[mid] >= x)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return ans;

        }
    }
}
