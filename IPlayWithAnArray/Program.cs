
int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

bool nIter = true;

while (nIter)
{
    nIter = false;
    int n = nums.Length;
    for (int i = 0; i < n-1; i++)
    {
        for (int j = 0; j < n-i-1; j++)
        {
            if (nums[j+1] > nums[j])
            {
                int temp = nums[j+1];
                nums[j+1] = nums[j];
                nums[j] = temp;
                nIter = true;
            }
        }
    }



}
foreach(int i in nums)
{
    Console.Write(i+" ");
}







