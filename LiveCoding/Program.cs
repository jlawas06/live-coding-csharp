using LiveCoding;


var input = "123211";

var isPalindrome = Palindrome.IsPalindrome(input);

Console.WriteLine($"{input} is palindrome: {isPalindrome}");


var number = 15;

Console.WriteLine($"Is {number} prime: {PrimeNumber.IsPrime(number)}");

Console.ReadKey();