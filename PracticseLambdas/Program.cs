// See https://aka.ms/new-console-template for more information

// Example Lambdas expressions tutorial 

// List of numbers odds and evens
List<int> num = new List<int> { 1, 2, 3 ,4, 5, 6, 7};

// Lambdas expression to check if a number is odd or even
Func<int, bool> isOdd = num => num % 2 > 0;

// Foreach item in the list delegate the number in the list to check if odd or even
// Includes a Console.WriteLine("") to print to the console in a loop
num.ForEach(delegate (int nums){
    bool isXOdd = isOdd(nums);
    Console.WriteLine(isXOdd);
});