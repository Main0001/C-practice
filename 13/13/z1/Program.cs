using System;

Operation operation = ExpOne;
double result = operation(4);
Console.WriteLine(result);

operation = ExpTwo;
result = operation(5);
Console.WriteLine(result);

operation = ExpThree;
result = operation(3);
Console.WriteLine(result);

Display(operation);

double ExpOne(int x) => Math.Pow(x, 2);
double ExpTwo(int x) => Math.Pow(x, 3);
double ExpThree(int x) => Math.Pow(x, 4);

void Display(Operation expResult) => Console.WriteLine($"Result: {expResult(2)}");

delegate double Operation(int x);
