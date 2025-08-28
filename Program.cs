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


// Doubles 
// floating point numbers are useful to repesent nonintegral numbers that
// might be small or large in magnitude
// double precision = 2x the number of bits as single

double doubleA = 5;
double doubleB = 4;
double doubleC = 2;
double doubleD = (doubleA + doubleB) / doubleC; // 9 / 2 -> 4.5
Console.WriteLine(doubleD);

double doubleE = 19;
double doubleF = 23;
double doubleG = 8;
double doubleH = (doubleE + doubleF) / doubleG; // 42 / 8 -> 5.25
Console.WriteLine(doubleH);

double doubleMax = double.MaxValue;
double doubleMin = double.MinValue;
Console.WriteLine($"The range of double is {doubleMin} to {doubleMax}");

// Floating point rounding errors
double third = 1.0 / 3.0; // should be 0.3333333...
Console.WriteLine(third); //0.3333333333333333


// decimal types
// more precision and smaller range than double
decimal decimalMin = decimal.MinValue;
decimal decimalMax = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {decimalMin} to {decimalMax}");

double doubleX = 1.0;
double doubleY = 3.0;
Console.WriteLine(doubleX / doubleY); // 0.3333333333333333

decimal decimalX = 1.0M;
decimal decimalY = 3.0M;
Console.WriteLine(decimalX / decimalY); // 0.3333333333333333333333333333

// M suffix for decimal literals. otherwise treated as double by default

// Challenge
// Write code that calculates the area of a circle whose radius is 2.50 centimeters. 
// Remember that the area of a circle is the radius squared multiplied by PI

double radius = 2.50;
double area = radius * radius * Math.PI;
Console.WriteLine($"Area of a circle with radius {radius} cm is {area} cm^2");
