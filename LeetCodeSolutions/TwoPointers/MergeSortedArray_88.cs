namespace LeetCodeSolutions.TwoPointers;

internal class MergeSortedArray_88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var p1 = m - 1;
        var p2 = n - 1;
        var cursor = nums1.Length - 1;

        while (p1 >= 0 && p2 >= 0)
        {
            if (nums1[p1] > nums2[p2])
            {
                nums1[cursor] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[cursor] = nums2[p2];
                p2--;
            }
            cursor--;
        }

        while (p2 >= 0)
        {
            nums1[cursor] = nums2[p2];
            p2--;
            cursor--;
        }
    }
}
