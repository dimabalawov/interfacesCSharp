
using MyArraySpace;

MyArray array = new MyArray(20);
array.FillWRandom();

Console.WriteLine("Array Elements:");
array.show();

int compareValue = 50;
Console.WriteLine($"\nNumber of elements greater than {compareValue}: {array.Greater(compareValue)}");
Console.WriteLine($"Number of elements less than {compareValue}: {array.Less(compareValue)}");

Console.WriteLine("\nEven Elements:");
array.showEven();

Console.WriteLine("\nOdd Elements:");
array.showOdd();

Console.WriteLine($"\nCount of Distinct Elements: {array.CountDistinct()}");

int valueToCompare = 25;
Console.WriteLine($"Number of elements equal to {valueToCompare}: {array.EqualToValue(valueToCompare)}");