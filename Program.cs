// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System;
using System.Text;

Console.WriteLine("Hello, World!");

// Primitive Data Types

// // Integral
// Choose the smallest type your value fits into

// sbyte: range from -128 - 127
sbyte z = 127;

short y = 32767;
// range from -32,768 - 32,767

int x = 2147483647;
// range from -2,147,483,648 - 2,147,483,647

long w = 9223372036854775807;
// range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

// // Floating point
// Use float for 3D graphics, double for everything (except money calculations) and decimal for financial applications.

float v = 0.5f;
// range from 1.5 × 10^−45 - 3.4 × 10^38, 7-digit precision

double u = 0.5;
// range from 5.0 × 10^−324 - 1.7 × 10^308, 15-digit precision

decimal t = 0.5m;
// range from –7.9 × 10^−28 - 7.9 × 10^28, 28-digit precision