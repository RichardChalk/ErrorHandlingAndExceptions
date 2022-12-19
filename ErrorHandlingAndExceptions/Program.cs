
// Ta bort kommentaren från den metod du vill köra
// ArrayReferenceError();
// ArrayReferenceErrorTryCatch();
// GetNumberFromUser();
// GetNumberFromUserTryCatch();
// Flow();
// CatchCatchCatch();
// ThrowSnake();
// ThrowSnakeNotSupported();
// ThrowSnakeAvoid();
ThrowSnakeCleanerCode();




// Array Reference Error ========================================
static void ArrayReferenceError()
{
    // Skapa en array av max index 4
    int[] arr = { 1, 2, 3, 4, 5 };

    // Visa alla element i array
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

    // Försök att komma åt en index som inte finns i array!
    Console.WriteLine(arr[7]);
    // EXCEPTION is thrown!
}

// Array Reference Error TRY CATCH ========================================
static void ArrayReferenceErrorTryCatch()
{
    // Skapa en array av max index 4
    int[] arr = { 1, 2, 3, 4, 5 };

    // Visa alla element i array
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }

    try
    {
        // Try to access invalid index of array
        Console.WriteLine(arr[7]);
    }
    catch (IndexOutOfRangeException e)
    {
        // Istället för att vår program kraschar så får vi ett felmeddelande!
        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
}

// Get Number From User =====================================================
static int GetNumberFromUser()
{
    int usersNumber = 0;
    while (usersNumber < 1 || usersNumber > 10)
    {
        Console.Write("Välj ett nummer mellan 1 och 10: ");
        string usersResponse = Console.ReadLine();
        usersNumber = Convert.ToInt32(usersResponse);
        // Skriver man en bokstav får vi en Exception!! 
        // Programmet kraschar!
    }
    return usersNumber;
}

// Get Number From User Try Catch =====================================================
static int GetNumberFromUserTryCatch()
{
    int usersNumber = 0;
    while (usersNumber < 1 || usersNumber > 10)
    {
        try
        {
            Console.Write("Enter a number between 1 and 10: ");
            string usersResponse = Console.ReadLine();
            usersNumber = Convert.ToInt32(usersResponse);
        }
        catch (Exception e)
        {
            Console.WriteLine("That is not a valid number. Try again.");
            Console.WriteLine(e.Message);
        }
    }
    return usersNumber;
}

// FLOW ================================================================
static void Flow()
{
    string content = string.Empty;

    try
    {
        Console.WriteLine("First message inside try block.");
        Console.WriteLine("Second message inside try block.");
        content = System.IO.File.ReadAllText(@"C:\file.txt");
        Console.WriteLine
    ("Third message inside try block. This shouldn't be printed.");
    }
    catch
    {
        Console.WriteLine("First message inside the catch block.");
        Console.WriteLine("Second message inside the catch block.");
    }

    Console.WriteLine("Outside the try-catch.");
    Console.ReadLine();
}

// CATCH CATCH CATCH ===================================================

static void CatchCatchCatch()
{
    int[] arr = { 19, 0, 75, 52 };

    try
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] / arr[i + 1]);
        }
    }
    catch (IndexOutOfRangeException e)
    {

        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    catch (DivideByZeroException e)
    {

        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    catch (ArgumentOutOfRangeException e)
    {

        Console.WriteLine("An Exception has occurred : {0}", e.Message);
    }
    finally
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0}", arr[i]);
        }
    }
}

// Throw Snake =========================================================
static void ThrowSnake()
{
    Console.WriteLine("Name any animal: ");
    string animal = Console.ReadLine();
    if (animal == "snake")
    {
        throw new Exception();
    }
}

// Throw Snake NOT SUPPORTED =========================================================
static void ThrowSnakeNotSupported()
{
    Console.WriteLine("Name any animal: ");
    string animal = Console.ReadLine();
    if (animal == "snake")
    {
        throw new NotSupportedException();
    }
}

// Throw Snake AVOID =========================================================
static void ThrowSnakeAvoid()
{
    // This seems unnecessary!
    try
    {
        Console.WriteLine("Name any animal: ");
        string animal = Console.ReadLine();
        if (animal == "snake")
        {
            throw new NotSupportedException();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Oooohhh I hate snakes?");
    }
}

// Throw Snake CLEANER CODE =========================================================
static void ThrowSnakeCleanerCode()
{
    Console.WriteLine("Name any animal: ");
    string animal = Console.ReadLine();
    if (animal == "snake")
    {
        Console.WriteLine("Oooohhh I hate snakes? Much cleaner code!");
    }
}
