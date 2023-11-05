int[] MergeSort(int[] nums, int L, int R)
{

    if (L < R)
    {
        int M = (R+L)/ 2;
        MergeSort(nums, L, M);
        MergeSort(nums, M + 1, R);
        Merge(nums, L, M, R);
    }
    return nums;
}

// Merges two subarrays of arr[].
// First subarray is arr[l..m]
// Second subarray is arr[m+1..r]
void Merge(int[] arr, int l, int m, int r)
{

    // Find lengths of two subarrays to be merged
    int leftLength = m - l + 1;
    int rightLength = r - m;

    // Create temp arrays 
    var tempLeft = new int[leftLength];
    var tempRight = new int[rightLength];

    // Copy the sorted left & right halfs to temp arrays
    for (int a = 0; a < leftLength; a++)
    {
        tempLeft[a] = arr[l + a];
    }

    for (int b = 0; b < rightLength; b++)
    {
        tempRight[b] = arr[m + 1 + b];
    }

    // initial indexes of left and right sub-arrays
    int i = 0; // index for left
    int j = 0; // index for right
    int k = l; // Initial index of merged subarray array

    // Merge the two sorted halfs into the original array
    while (i < leftLength && j < rightLength)
    {
        if (tempLeft[i] <= tempRight[j])
        {
            arr[k] = tempLeft[i];
            i++;
        }
        else
        {
            arr[k] = tempRight[j];
            j++;
        }
        k++;
    }
    // One of the halfs will have elements remaining

    // Copy remaining elements of L[] if any 
    while (i < leftLength)
    {
        arr[k] = tempLeft[i];
        i++;
        k++;
    }

    // Copy remaining elements of R[] if any 
    while (j < rightLength)
    {
        arr[k] = tempRight[j];
        j++;
        k++;
    }
}


void PrintNums(int[] nums)
{
    foreach (int num in nums)
    {
        Console.Write($"{num} ");
    }
}

var nums = new int[] {3,2,4,1,6};

Console.WriteLine("BEFORE");
PrintNums(nums);
MergeSort(nums, 0, nums.Length - 1);
Console.WriteLine("AFTER");
PrintNums(nums);
// Output: [0,0,1,1,2,5])