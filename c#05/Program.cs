using System;

class Program
{
    static void Main(string[] args)
    {
        #region Value vs Reference Type Parameters

        //Console.WriteLine("Value Type - Pass by Value vs Reference:");

        //// Passing by Value
        //int num1 = 10;
        //ModifyValue(num1);
        //Console.WriteLine($"Original Value after Pass by Value: {num1}"); // Output: 10

        //// Passing by Reference
        //int num2 = 10;
        //ModifyValueByRef(ref num2);
        //Console.WriteLine($"Original Value after Pass by Reference: {num2}"); // Output: 20

        //static void ModifyValue(int x)
        //{
        //    x = 20;
        //}

        //static void ModifyValueByRef(ref int x)
        //{
        //    x = 20;
        //}

        #endregion

        #region Sum of Digits

        //Console.Write("Enter a number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine($"The sum of the digits of the number {number} is: {SumOfDigits(number)}");

        //static int SumOfDigits(int num)
        //{
        //    int sum = 0;
        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;
        //    }
        //    return sum;
        //}

        #endregion

        #region IsPrime Function

        //Console.Write("Enter a number to check if it is prime: ");
        //int primeCheck = int.Parse(Console.ReadLine());
        //Console.WriteLine(IsPrime(primeCheck) ? "It is a prime number." : "It is not a prime number.");

        //static bool IsPrime(int num)
        //{
        //    if (num <= 1) return false;
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0) return false;
        //    }
        //    return true;
        //}

        #endregion

        #region MinMaxArray

        //int[] array = { 5, 1, 9, 3, 7 };
        //MinMaxArray(array, out int min, out int max);
        //Console.WriteLine($"Minimum: {min}, Maximum: {max}");

        //static void MinMaxArray(int[] arr, out int min, out int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    foreach (var item in arr)
        //    {
        //        if (item < min) min = item;
        //        if (item > max) max = item;
        //    }
        //}

        #endregion

        #region Iterative Factorial

        //Console.Write("Enter a number to calculate its factorial: ");
        //int factNum = int.Parse(Console.ReadLine());
        //Console.WriteLine($"Factorial of {factNum} is: {IterativeFactorial(factNum)}");

        //static int IterativeFactorial(int num)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        #endregion

        #region Reference Type - Pass by Value vs Reference

        //string original = "Hello";
        //ModifyString(original);
        //Console.WriteLine($"Original String after Pass by Value: {original}"); // Output: Hello

        //string originalRef = "Hello";
        //ModifyStringByRef(ref originalRef);
        //Console.WriteLine($"Original String after Pass by Reference: {originalRef}"); // Output: Hi

        //static void ModifyString(string str)
        //{
        //    str = "Hi";
        //}

        //static void ModifyStringByRef(ref string str)
        //{
        //    str = "Hi";
        //}

        #endregion

        #region Summation and Subtraction Function

        //Console.Write("Enter four numbers (space-separated): ");
        //string[] inputs = Console.ReadLine().Split();
        //int a = int.Parse(inputs[0]);
        //int b = int.Parse(inputs[1]);
        //int c = int.Parse(inputs[2]);
        //int d = int.Parse(inputs[3]);

        //var result = SummationAndSubtraction(a, b, c, d);
        //Console.WriteLine($"Summation: {result.Item1}, Subtraction: {result.Item2}");

        //static (int, int) SummationAndSubtraction(int x1, int x2, int x3, int x4)
        //{
        //    int sum = x1 + x2;
        //    int diff = x3 - x4;
        //    return (sum, diff);
        //}

        #endregion

        #region ChangeChar Function

        //Console.Write("Enter a string: ");
        //string inputStr = Console.ReadLine();
        //Console.Write("Enter the position to modify: ");
        //int position = int.Parse(Console.ReadLine());
        //Console.Write("Enter the new character: ");
        //char newChar = Console.ReadKey().KeyChar;
        //Console.WriteLine();
        //Console.WriteLine($"Modified String: {ChangeChar(inputStr, position, newChar)}");

        //static string ChangeChar(string str, int pos, char newChar)
        //{
        //    char[] charArray = str.ToCharArray();
        //    charArray[pos] = newChar;
        //    return new string(charArray);
        //}

        #endregion

        #region Enum - WeekDays

    //    Console.WriteLine("Days of the Week:");
    //    foreach (var day in Enum.GetValues(typeof(WeekDays)))
    //    {
    //        Console.WriteLine(day);
    //    }

    //    enum WeekDays
    //{
    //    Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    //}

    #endregion

    #region Enum - Season

    //Console.Write("Enter a season name: ");
    //    string seasonInput = Console.ReadLine();
    //Console.WriteLine(GetSeasonMonths(seasonInput));

    //    static string GetSeasonMonths(string season)
    //{
    //    return season.ToLower() switch
    //    {
    //        "spring" => "March to May",
    //        "summer" => "June to August",
    //        "autumn" => "September to November",
    //        "winter" => "December to February",
    //        _ => "Invalid season"
    //    };
    

    //enum Season
    //{
    //    Spring, Summer, Autumn, Winter
    //}

    #endregion

    #region Enum - Permissions

    //Permissions userPermissions = Permissions.Read | Permissions.Write;
    //Console.WriteLine($"Current Permissions: {userPermissions}");

    //    userPermissions |= Permissions.Delete; // Add permission
    //    Console.WriteLine($"Updated Permissions: {userPermissions}");

    //    userPermissions &= ~Permissions.Write; // Remove permission
    //    Console.WriteLine($"Permissions after removal: {userPermissions}");

    //    Console.WriteLine(userPermissions.HasFlag(Permissions.Execute)? "Has Execute permission" : "Does not have Execute permission");

    //    [Flags]
    //enum Permissions
    //{
    //    None = 0,
    //    Read = 1,
    //    Write = 2,
    //    Delete = 4,
    //    Execute = 8
    //}

    #endregion

    #region Enum - Colors

    //Console.Write("Enter a color name: ");
    //    string colorInput = Console.ReadLine();
    //Console.WriteLine(IsPrimaryColor(colorInput)? "It is a primary color." : "It is not a primary color.");

    //    static bool IsPrimaryColor(string color)
    //{
    //    return color.ToLower() switch
    //    {
    //        "red" => true,
    //        "green" => true,
    //        "blue" => true,
    //        _ => false
    //    };
    //}

    //enum Colors
    //{
    //    Red, Green, Blue
    //}

    #endregion


