// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Step 1: Integer math
int a = 18;
int b = 6;
int c = a - b;
Console.WriteLine(c);

// Order of operations PEMDAS
// Parentheses, Exponents, Multiplication, Division, Addition, Subtraction
int a = 5;
int b = 4;
int c = 2;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
// 9 - 6 * 2 + 48 / 3 + 12
// 9 - 12 + 16 + 12
// -3 + 28
// 25
Console.WriteLine(d);

// integer division always produces an integer result
int e = 7;
int f = 4;
int g = 3;
int h = (e + f) / g; // (7 + 4) / 3 -> 11 / 3 -> 3
Console.WriteLine(h);

// Explore integer precision and limits

int precisionA = 7;
int precisionB = 4;
int precisionC = 3;
int precisionD = (precisionA + precisionB) / precisionC; // 11 /
int precisionE = (precisionA + precisionB) % precisionC; // remainder of 11 / 3
Console.WriteLine($"quotient: {precisionD}, remainder: {precisionE}");

int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
