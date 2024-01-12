static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");
    // Create and fill an array of 3 Integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    // Now print each value.
    foreach(int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
}

static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initialization");

    // Array initialization syntax using the new keyword.
    string[] stringArray = new string[]
        {"one", "two", "three"};
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // Array initialization syntax without using the new keyword
    bool[] boolArray = {true, false};
    Console.WriteLine("bool has {0} elements.", boolArray.Length);

    // Array initialization with new keyword and size
    int[] intArray = new int[4] {1, 2, 3, 4};
    Console.WriteLine("intArray has {0} elements", intArray.Length);
    Console.WriteLine();
}

static void RectMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular multidimensional array");
    // A rectangular MD array.
    int[,] myMatrix;
    myMatrix = new int[3, 4];

    // Populate (3 * 4) array.
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jagged multidimensional array.");
    // A jagged MD array (i.e., an array of arrays)
    // Here we have an array of 5 different arrays.
    int[][] myJagArray = new int[5][];

    // Create the jagged array
    for(int i = 0; i < 5; i++)
    {
        myJagArray[i] = new int[5];
    }
}
