// See https://aka.ms/new-console-template for more information

using LeetCode.Y2024.M06.D28;

Console.WriteLine("-------------------------------Test case 1----------------------------------------");

var data = Implementation2024_06_28.GetFirstInput();
Console.WriteLine($"Result is: {Implementation2024_06_28.MaximumImportance(5, data)}");

Console.WriteLine("-------------------------------Test case 2----------------------------------------");

var data2 = Implementation2024_06_28.GetSecondInput();
Console.WriteLine($"Result is: {Implementation2024_06_28.MaximumImportance(5, data2)}");

Console.WriteLine("-------------------------------Test case 3----------------------------------------");

var data3 = Implementation2024_06_28.GetThirdInput();
Console.WriteLine($"Result is: {Implementation2024_06_28.MaximumImportance(5, data3)}");