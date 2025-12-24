// See https://aka.ms/new-console-template for more information
try
{
    int cols, rows;

    Console.Write("How many rows? ");
    rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("How many cols? ");
    cols = Convert.ToInt32(Console.ReadLine());

    int[][] matrix = new int[rows][];

    Console.WriteLine("Initilizing array...");
    for (int i = 0; i < matrix.Length; i++)
        matrix[i] = new int[cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"Enter value for matrix[{i}][{j}]:\t");
            matrix[i][j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    Console.WriteLine("Printing your matrix: ");

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matrix[i][j]}\t");
            Thread.Sleep(500 * i);
            Console.Beep();
        }
        Console.WriteLine();
    }
}
catch (Exception ex)
{
    // just ignore
}
