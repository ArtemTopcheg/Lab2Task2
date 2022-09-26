//Task2

int[,,] nums = new int[3, 3, 3];
Random rnd = new Random();
for (int i = 0; i < nums.GetLength(0); i++)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        for (int k = 0; k < nums.GetLength(2); k++)
        {
            nums[i, j, k] = rnd.Next(-5,5) % 10;
            if (nums[i, j, k] > 0)
            {
                nums[i, j, k] = 0;
            }
            Console.Write(nums[i, j, k] + "  ");
        }
    }
    Console.WriteLine();
}