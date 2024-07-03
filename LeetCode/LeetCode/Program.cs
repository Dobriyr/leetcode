// See https://aka.ms/new-console-template for more information

using LeetCode.Y2024.M06.D28;
using LeetCode.Y2024.M07.D03;

Console.WriteLine("-------------------------------Test case 1----------------------------------------");

var data = Implementation2024_07_03.MinDifference([1, 5, 0, 10, 14]);
Console.WriteLine(data);

Console.WriteLine("-------------------------------Test case 2----------------------------------------");
var data1 = Implementation2024_07_03.MinDifference([6, 6, 0, 1, 1, 4, 6]);
Console.WriteLine(data1);

Console.WriteLine("-------------------------------Test case 3----------------------------------------");
var data2 = Implementation2024_07_03.MinDifference([20, 66, 68, 57, 45, 18, 42, 34, 37, 58]);
Console.WriteLine(data2);

Console.WriteLine("-------------------------------Test case 4----------------------------------------");
var data3 = Implementation2024_07_03.MinDifference([9, 48, 92, 48, 81, 31]);
Console.WriteLine(data3);