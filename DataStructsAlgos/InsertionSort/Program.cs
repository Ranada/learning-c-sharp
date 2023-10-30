int[] InsertionSort(int[] nums)
{
    if (nums.Length < 2)
    {
        return nums;
    }

    for (int R = 1; R < nums.Length; R++)
    {
        int currentNum = nums[R];
        int L = R - 1;

        while (L >= 0 && nums[L] > currentNum)
        {
            nums[L + 1] = nums[L];
            L -= 1;
        }
        nums[L + 1] = currentNum;
    }

    return nums;
}


void PrintArray(int[] nums)
{
    foreach (int num in nums)
    {
        Console.Write($"{num} ");
    }
}

var nums = new int[] {2,3,4,1,6}; 

Console.Write("Before: ");
PrintArray(nums);

InsertionSort(nums);

Console.Write("\nAfter: ");
PrintArray(nums); // Expect 1 2 3 4 6

// 1,2,3,4,6
// L
//       R