﻿// See https://aka.ms/new-console-template for more information
using BlokMath;
using BlokMath.Functions;

Console.WriteLine("Podaj parametry:");

string a_s, b_s, c_s;

Console.Write("a = ");
a_s = Console.ReadLine();

Console.Write("b = ");
b_s = Console.ReadLine();

Console.Write("c = ");
c_s = Console.ReadLine();

Console.WriteLine();

var squareFunction = new SquareFunction();
squareFunction.SquareFunctionBuildAsGeneral(decimal.Parse(a_s), decimal.Parse(b_s), decimal.Parse(c_s));


Console.WriteLine("Wyniki:");
Console.WriteLine("a = " + squareFunction.a);
Console.WriteLine("b = " + squareFunction.b);
Console.WriteLine("c = " + squareFunction.c);

Console.WriteLine("p = "+ squareFunction.p);
Console.WriteLine("q = "+ squareFunction.q);

Console.WriteLine("Δdelta = " + squareFunction.Delta);
Console.WriteLine("√Δdeltasqrt= " + squareFunction.DeltaSqrt);

Console.WriteLine("x1 = " + squareFunction.x1);
Console.WriteLine("x2 = " + squareFunction.x2);
